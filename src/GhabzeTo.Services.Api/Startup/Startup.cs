using Autofac;
using GhabzeTo.Infra.CrossCutting.IoC;
using GhabzeTo.Infra.Data.EF.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Autofac.Extensions.DependencyInjection;
using GhabzeTo.Domain.Core.Settings;
using GhabzeTo.Infra.Data.EF.Uow;
using System;
using System.Linq;
using GhabzeTo.Services.Api.Extensions;
using GhabzeTo.Services.Api.Infra.MiddleWares;
using FluentValidation;
using FluentValidation.Results;
using System.IO;
using Swashbuckle.AspNetCore.Swagger;
using ElmahCore.Mvc;
using ElmahCore.Sql;

namespace GhabzeTo.Services.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static SiteSettings SiteSettings { get; set; }
        public IContainer ApplicationContainer { get; set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //------------------------------------------------------------------
            // load configuration file
            services.Configure<SiteSettings>(options => Configuration.Bind(options));

            // set database context based on configuration
            SiteSettings = services.GetSiteSettings();
            services.AddRequiredEfInternalServices(SiteSettings);
            services.AddDbContextPool<EfUnitOfWork>((_, optionsBuilder) =>
            {
                optionsBuilder.SetDbContextOptions(SiteSettings);
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Override default .net core model binding errors
            services.Configure<ApiBehaviorOptions>(o =>
            {
                o.InvalidModelStateResponseFactory = actionContext =>
                    throw new ValidationException(actionContext.ModelState.Select(x => new ValidationFailure(x.Key, string.Join(",", x.Value.Errors.Select(c => c.ErrorMessage)))));
            });

            //Add Swagger
            services.AddSwaggerGen(swagger =>
            {
                swagger.DescribeAllEnumsAsStrings();
                swagger.DescribeAllParametersInCamelCase();
                //  swagger.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "GhabzeTo Swagger" });
                swagger.SwaggerDoc("v1", new Info()
                {
                    Version = "v1",
                    Title = "GhabzeTo API",
                    Description = "An application to manage billings",
                    TermsOfService = new Uri("https://example.com/terms").ToString(),
                    Contact = new Contact
                    {
                        Name = "Mojtaba Nikoonejad",
                        Email = "m0jt0ba@gmail.com",
                        Url = new Uri("https://twitter.com/mojtabanik").ToString(),
                    },
                    License = new License()
                    {
                        Name = "SimabT",
                        Url = new Uri("https://simabt.com/").ToString(),
                    }
                });
                swagger.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Swagger.xml"));
            });

            //Add Elmah for checking exceptions
            services.AddElmah<SqlErrorLog>(options =>
            {
                options.Path = @"errors";
                options.ConnectionString = SiteSettings.GetDbConnectionString();
                options.ApplicationName = "GhabzeTo";
                // options.CheckPermissionAction = context => context.User.Identity.IsAuthenticated;
            });

            //AutoFac Registration
            var container = new ContainerBuilder();
            container.Populate(services);
            container.RegisterModule(new AutofacModule());
            this.ApplicationContainer = container.Build();
            return new AutofacServiceProvider(this.ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Exception Logs
            app.UseElmah();

            //Log Requests and Response
            app.UseRequestResponseLogging();

            //Api Validation,UserFriendly,UnhandledException handling
            app.UseExceptionAndResponseMessageHandling();

            //Swagger
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "GhabzeTo API");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseMvc();


        }
    }
}
