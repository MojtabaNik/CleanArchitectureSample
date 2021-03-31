using GhabzeTo.Infra.Resources.SystemErrors;
using System;

namespace GhabzeTo.Application.Core.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() : base()
        {
            throw new EntityNotFoundException(SystemErrorResourceKeys.EntityNotFound);
        }

        public EntityNotFoundException(string message) : base(message)
        {
        }

        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
