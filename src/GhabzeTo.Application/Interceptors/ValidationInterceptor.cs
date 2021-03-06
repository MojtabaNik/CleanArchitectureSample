using Autofac;
using Castle.DynamicProxy;
using FluentValidation;
using GhabzeTo.Application.Core;
using GhabzeTo.Application.Core.Exceptions;
using GhabzeTo.Application.Core.Extensions;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application.Interceptors
{
    public class ValidationInterceptor : IInterceptor
    {
        private readonly IComponentContext _container;

        public ValidationInterceptor(IComponentContext container)
        {
            _container = container;
        }

        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.ReflectedType?.IsGenericType == true && invocation.Method.ReflectedType.GetGenericTypeDefinition() == typeof(IApplicationService<,,,,>) && invocation.Arguments.Length > 0)
            {
                // _systemEventLogService.Log("Intercept Method Starts");
                foreach (var arg in invocation.Arguments)
                {
                    if (arg == null)
                    {
                        throw new UserFriendlyException(ValidationResourceKeys.InputDataTypeProblem);
                    }

                    //Do Validation
                    var validatorType = arg.GetValidator();

                    if (validatorType != null)
                    {
                        //  _systemEventLogService.Log($"Validator Found for input data of type {arg.GetType().FullName}");
                        var validatorInstance = (IValidator)_container.Resolve(validatorType);
                        var results = validatorInstance.Validate(arg);

                        if (!results.IsValid)
                        {
                            //  _systemEventLogService.Log("Validation Error for input data.", Domain.Models.Logs.SystemEventLogType.Error, results.Errors);
                            throw new ValidationException(results.Errors);
                        }
                        else
                        {
                            // _systemEventLogService.Log("Validation success for data", Domain.Models.Logs.SystemEventLogType.Info, arg);
                        }
                    }
                    else
                    {
                        // _systemEventLogService.Log($"Validator Not Found for input data of type {arg.GetType().FullName}", Domain.Models.Logs.SystemEventLogType.Warn);
                    }
                }
            }

            invocation.Proceed();
        }
    }
}
