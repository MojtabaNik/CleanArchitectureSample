using System;
using System.Threading.Tasks;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Models.Logs;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;

namespace GhabzeTo.Application.Services
{
    public class SystemCallService : ISystemCallService
    {
        private readonly IRepository<SystemCall, Guid> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public SystemCallService(IRepository<SystemCall, Guid> repository,
                                 IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Create(SystemCall systemCall)
        {
            var Id = await _repository.InsertAndGetIdAsync(systemCall).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync();
            return Id;
        }

        public Task Update(Guid Id, string outPutData)
        {
            var systemCall = _repository.Get(Id);
            if (systemCall != null)
            {
                systemCall.Output = outPutData;
            }

            return _unitOfWork.SaveChangesAsync();
        }
    }
}
