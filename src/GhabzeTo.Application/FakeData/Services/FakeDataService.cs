using AutoBogus;
using GhabzeTo.Application.Core.Exceptions;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Infra.Resources.SystemErrors;
using System;
using System.Reflection;

namespace GhabzeTo.Application.Services
{
    public class FakeDataService : IFakeDataService
    {
        public object GetFakeObject(int numberOfObjects, string dtoName)
        {
            var typeArgument = Array.Find(Assembly.GetExecutingAssembly().GetTypes(), x => x.Name.Equals(dtoName, StringComparison.OrdinalIgnoreCase));

            if (typeArgument == null)
            {
                throw new EntityNotFoundException(SystemErrorResourceKeys.EntityNotFound);
            }

            var genericClass = typeof(AutoFaker<>);
            var constructedClass = genericClass.MakeGenericType(typeArgument);
            dynamic faker = Activator.CreateInstance(constructedClass);
            return (dynamic)faker.Generate(numberOfObjects);
        }
    }
}
