using System;
using System.Linq;
using FluentValidation;
using System.Reflection;

namespace GhabzeTo.Application.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static Type GetValidator(this object entity)
        {
            if (entity == null)
                return null;

            var assemblies = Assembly.GetCallingAssembly().GetTypes().ToList();
            assemblies.AddRange(Assembly.GetExecutingAssembly().GetTypes());

            var validatorType = assemblies
                                    .Find(x => x != null
                                               && x.IsClass
                                               && x.BaseType?.IsGenericType == true
                                               && x.BaseType.GetGenericTypeDefinition() ==
                                               typeof(AbstractValidator<>)
                                               && x.Name.IndexOf(entity.GetType().Name,
                                               StringComparison.OrdinalIgnoreCase) >= 0);

            return validatorType;
        }
    }
}
