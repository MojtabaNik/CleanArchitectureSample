using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElmahCore;
using ElmahCore.Postgresql;
using ElmahCore.Sql;
using FluentValidation;
using GhabzeTo.Application.Core.DTOs.SystemCall;
using GhabzeTo.Application.Core.Exceptions;
using GhabzeTo.Domain.Core.Settings;
using GhabzeTo.Infra.Data.EF.Config;
using GhabzeTo.Infra.Resources.SystemErrors;
using GhabzeTo.Infra.Resources.SystemMessages;
using GhabzeTo.Infra.Resources.Validations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace GhabzeTo.Services.Api.Infra.MiddleWares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    /// <summary>
    /// Exception Handling
    /// </summary>
    public class ExceptionAndResponseMessageHandling
    {
        private readonly RequestDelegate _next;
        private readonly IHostingEnvironment _env;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="next"></param>
        /// <param name="env"></param>
        public ExceptionAndResponseMessageHandling(RequestDelegate next, IHostingEnvironment env)
        {
            _next = next;
            _env = env;
        }

        /// <summary>
        /// Invoke method which runs on middle ware , when a request come out from application
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext httpContext, CurrentSystemCallInfo currentSystemCallInfo)
        {
            //prop initialization
            //var status = ResponseStatus.UnhandledError;
            //var message = SystemErrorResourceKeys.SystemUnhandledException;
            var responseObject = new object();

            bool hasError = true;
            try
            {
                await _next(httpContext);
                hasError = false;

                var message = "";

                //Success message of web api
                switch (httpContext.Request.Method.ToLower())
                {
                    case "post":
                        message = SystemMessagesResourceKeys.PostSuccess;
                        httpContext.Response.StatusCode = StatusCodes.Status201Created;
                        break;
                    case "get":
                        message = SystemMessagesResourceKeys.GetSuccess;
                        break;
                    case "put":
                        message = SystemMessagesResourceKeys.PutSuccess;
                        break;
                    case "delete":
                        message = SystemMessagesResourceKeys.DeleteSuccess;
                        break;
                    default:
                        message = "نتیجه نامعلوم";
                        httpContext.Response.StatusCode = StatusCodes.Status200OK;
                        break;
                }


                if (httpContext.Response.Body.Length == 0)
                {
                    //httpContext.Response.Clear();
                    httpContext.Response.ContentType = "application/json";
                    string json = JsonConvert.SerializeObject(new { Message = message });
                    await httpContext.Response.WriteAsync(json).ConfigureAwait(false);
                }


            }
            catch (ValidationException ex)
            {
                httpContext.Response.Clear();
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;

                var properties = new List<string>();

                var validationMessages = ex.Errors.Select(error =>
                {
                    if (!properties.Any(c => c == error.PropertyName))
                    {
                        //In case if error message is: A non-empty request body is required.
                        if (string.IsNullOrEmpty(error.PropertyName))
                        {
                            return new ValidationMessage
                            {
                                PropertyName = "RequestBody",
                                Messages = new List<string> { ValidationResourceKeys.RequestBodyNull }
                            };
                        }

                        var validationMessage = new ValidationMessage
                        {
                            PropertyName = error.PropertyName,
                            Messages = ex.Errors.Where(x => x.PropertyName.Equals(error.PropertyName))
                                .Select(x => x.ErrorMessage)
                        };
                        properties.Add(error.PropertyName);
                        return validationMessage;
                    }
                    else
                    {
                        return null;
                    }
                }).Where(x => x != null).AsEnumerable();

                responseObject = new { Message = ValidationResourceKeys.ValidationErrorMessage, validationMessages };
            }
            catch (EntityNotFoundException ex)
            {
                httpContext.Response.Clear();
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                responseObject = new { ex.Message };
            }
            catch (UserFriendlyException ex)
            {
                httpContext.Response.Clear();
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                responseObject = new { ex.Message };
            }
            catch (Exception ex)
            {
                httpContext.Response.Clear();
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

                if (_env.IsDevelopment())
                {
                    responseObject = new { Message = SystemErrorResourceKeys.SystemUnhandledException, Exception = ex };
                }
                else
                {
                    var elmahError = new Error(ex);
                    elmahError.User = currentSystemCallInfo.Id.ToString();

                    //Log in elmah
                    //Log error with elmah before create response
                    if (Startup.SiteSettings.ActiveDatabase == ActiveDatabase.SqlServer)
                    {
                        ErrorLog errorLog = new SqlErrorLog(Startup.SiteSettings.GetDbConnectionString())
                        {
                            ApplicationName = "GhabzeTo"
                        };
                        await errorLog.LogAsync(elmahError).ConfigureAwait(false);
                    }
                    else if (Startup.SiteSettings.ActiveDatabase == ActiveDatabase.PostgreSQL)
                    {
                        ErrorLog errorLog = new PgsqlErrorLog(Startup.SiteSettings.GetDbConnectionString())
                        {
                            ApplicationName = "GhabzeTo"
                        };
                        await errorLog.LogAsync(elmahError).ConfigureAwait(false);
                    }

                    responseObject = new { Message = SystemErrorResourceKeys.SystemUnhandledException };
                }
            }

            if (hasError)
            {
                string json = JsonConvert.SerializeObject(responseObject);
                await httpContext.Response.WriteAsync(json).ConfigureAwait(false);
            }
        }
    }

    internal class ValidationMessage
    {
        public string PropertyName { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    /// <summary>
    /// Helper Class
    /// </summary>
    public static class ExceptionHandlingExtensions
    {
        /// <summary>
        /// This method is used for handling all kind of system exceptions and create response for them
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseExceptionAndResponseMessageHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionAndResponseMessageHandling>();
        }
    }
}
