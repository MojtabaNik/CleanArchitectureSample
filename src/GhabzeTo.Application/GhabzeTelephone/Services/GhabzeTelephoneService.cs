using Autofac;
using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Models.GhabzeTelephone;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;
using System;

namespace GhabzeTo.Application.Services
{
    public class GhabzeTelephoneService : ApplicationService<Guid, GhabzeTelephone, GhabzeTelephoneInputDto, GhabzeTelephoneBatchInsertOutputDto, GhabzeTelephoneOutPutDto>, IGhabzeTelephoneService
    {
        private readonly IRepository<GhabzeTelephone, Guid> _repository;

        public GhabzeTelephoneService(IRepository<GhabzeTelephone, Guid> repository,
                           IMapper mapper,
                           IComponentContext container,
                           ISystemEventLogService systemEventLogService,
                           IUnitOfWork unitOfWork) : base(mapper, repository, container, systemEventLogService, unitOfWork)
        {
            _repository = repository;
        }
    }
}
