using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using FluentValidation;
using GhabzeTo.Application;
using GhabzeTo.Application.Interceptors;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;
using GhabzeTo.Infra.Data.EF.Repositories;
using GhabzeTo.Infra.Data.EF.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using GhabzeTo.Application.Core;
using GhabzeTo.Application.Core.DTOs.SystemCall;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Application.Services;
using System.Diagnostics;

namespace GhabzeTo.Infra.CrossCutting.IoC
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<HttpContextAccessor>()
                .As<IHttpContextAccessor>()
                .SingleInstance();

            #region InfraLayer
            //UnitOfWork

            //DbOptions
            //var dbOptions = new DbContextOptionsBuilder();
            //dbOptions.SetDbContextOptions(_siteSettings);

            //builder
            //    .RegisterType<EfUnitOfWork>()
            //    .WithParameter("options", dbOptions)
            //    .InstancePerLifetimeScope();
            builder
                .Register(ctx => ctx.Resolve<EfUnitOfWork>())
                .As<DbContext>()
                .InstancePerLifetimeScope();

            builder
                .Register(ctx => ctx.Resolve<EfUnitOfWork>())
                .As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            //Repository
            builder
                .RegisterGeneric(typeof(EfRepositoryBase<>))
                .As(typeof(IRepository<>));

            builder
                .RegisterGeneric(typeof(EfRepositoryBase<,>))
                .As(typeof(IRepository<,>));
            #endregion

            #region ApplicationServiceLayer

            #region AutoMapper
            //Auto mapper profiles add
            //Get all Profiles
            var profiles = from t in typeof(ApplicationService<,,,,>).Assembly.GetTypes()
                           where typeof(Profile).IsAssignableFrom(t)
                           select (Profile)Activator.CreateInstance(t);

            //Create a mapper that will be used by the DI container
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            }));

            builder.Register(ctx => ctx
                .Resolve<MapperConfiguration>()
                .CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
            #endregion

            #region Services
            //Services
            var applicationLayer = typeof(ApplicationService<,,,,>).Assembly;
            var applicationServices = applicationLayer.GetTypes().Where(t => t.Name.EndsWith("Service") && t.BaseType?.IsGenericType == true && t.BaseType.GetGenericTypeDefinition() == typeof(ApplicationService<,,,,>)).ToArray();
            builder.RegisterTypes(applicationServices)
                   .AsImplementedInterfaces()
                   .InstancePerDependency()
                   .EnableInterfaceInterceptors()
                     .InterceptedBy(typeof(ValidationInterceptor));

            //Other ApplicationLayer Services
            builder.RegisterType<SystemEventLogService>().As<ISystemEventLogService>().InstancePerLifetimeScope();
            builder.RegisterType<FakeDataService>().As<IFakeDataService>().InstancePerDependency();
            builder.RegisterType<SystemCallService>().As<ISystemCallService>().InstancePerDependency();

            builder.Register(_ => new CurrentSystemCallInfo()).InstancePerLifetimeScope();

            //Validators
            builder.RegisterAssemblyTypes(applicationLayer)
                .Where(t => t.Name.EndsWith("Validator"))
                .AsSelf()
                .SingleInstance();

            var applicationCoreLayer = typeof(IApplicationService<,,,,>).Assembly;
            builder.RegisterAssemblyTypes(applicationCoreLayer)
                .Where(t => t.Name.EndsWith("Validator"))
                .AsSelf()
                .SingleInstance();

            builder
                .RegisterType<AutofacValidatorFactory>()
                .As<IValidatorFactory>()
                .SingleInstance();

            //Interceptors
            // Typed registration
            builder
                .RegisterType<ValidationInterceptor>()
                .AsSelf()
                .SingleInstance();
            #endregion

            #endregion
        }
    }
}
