using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using GhabzeTo.Application.Core.DTOs.SystemCall;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Models.Logs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Extensions;

namespace GhabzeTo.Services.Api.Infra.MiddleWares
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(
            RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ISystemCallService systemCallService, CurrentSystemCallInfo currentSystemCallInfo)
        {
            //code dealing with request

            //First, get the incoming request
            var requestLog = await FormatRequest(context.Request).ConfigureAwait(false);

            //Copy a pointer to the original response body stream
            var originalBodyStream = context.Response.Body;

            currentSystemCallInfo.Id = await systemCallService.Create(new SystemCall()
            {
                InputWay = context.Request.Method + " " + context.Request.GetDisplayUrl(),
                InputData = requestLog,
                InputMetaData = $"{{\"ClientIp\":\"{context.Connection.RemoteIpAddress}\", \"Scheme\": \"{context.Request.Scheme}\",\"Host\":\"{context.Request.Host}\",\"Headers\":\"{context.Request.Headers}\",\"Path\":\"{context.Request.Path}\",\"QueryStrings\":\"{context.Request.QueryString}\",\"Method\":\"{context.Request.Method}\"}}"
            }).ConfigureAwait(false);

            //Create a new memory stream...
            using (var responseBody = new MemoryStream())
            {
                //...and use that for the temporary response body
                context.Response.Body = responseBody;

                await _next(context).ConfigureAwait(false);

                var responseLog = await FormatResponse(context.Response).ConfigureAwait(false);

                await systemCallService.Update(currentSystemCallInfo.Id, responseLog).ConfigureAwait(false);

                //In Case If We Only want Api log
                //We should save log only if we are calling our web api class
                //var routeData = context.GetRouteData();
                //if (routeData != null)
                //{
                //    var controller = context.GetRouteData().Values["Controller"];
                //    if (!string.IsNullOrEmpty(controller.ToString()))
                //    {
                //        var controllerClass = Array.Find(
                //            Assembly.GetExecutingAssembly().GetTypes(),
                //            x => typeof(BaseApiController).IsAssignableFrom(x) && x.Name.Contains(controller.ToString()));

                //        if (controllerClass != null)
                //        {
                //            //Format the response from the server
                //            var response = await FormatResponse(context.Response).ConfigureAwait(false);
                //            //save log to database
                //            var log = requestLog + "</br>" + response;
                //        }
                //    }
                //}

                //Copy the contents of the new memory stream (which contains the response) to the original stream, which is then returned to the client.
                await responseBody.CopyToAsync(originalBodyStream).ConfigureAwait(false);
            }
        }

        private async Task<string> FormatRequest(HttpRequest request)
        {
            request.EnableRewind();

            var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            await request.Body.ReadAsync(buffer, 0, buffer.Length);
            var bodyAsText = Encoding.UTF8.GetString(buffer);
            request.Body.Position = 0;

            return bodyAsText;
        }

        private async Task<string> FormatResponse(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            var text = await new StreamReader(response.Body).ReadToEndAsync().ConfigureAwait(false);
            response.Body.Seek(0, SeekOrigin.Begin);

            return text;
        }
    }

    /// <summary>
    /// Extension class for Request Response Logging middleware
    /// </summary>
    public static class RequestResponseLoggingExtensions
    {
        /// <summary>
        /// This method should call before UseMvc and after All Middlewares
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseRequestResponseLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestResponseLoggingMiddleware>();
        }
    }
}
