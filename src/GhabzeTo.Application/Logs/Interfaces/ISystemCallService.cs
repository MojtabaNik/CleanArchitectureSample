using GhabzeTo.Domain.Models.Logs;
using System;
using System.Threading.Tasks;

namespace GhabzeTo.Application.Interfaces
{
    public interface ISystemCallService
    {
        Task<Guid> Create(SystemCall systemCall);
        Task Update(Guid Id, string outPutData);
    }
}
