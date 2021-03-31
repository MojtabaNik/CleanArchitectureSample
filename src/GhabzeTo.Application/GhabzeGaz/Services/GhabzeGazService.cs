using Autofac;
using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Models.GhabzeGaz;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;
using System;

namespace GhabzeTo.Application.Services
{
    public class GhabzeGazService : ApplicationService<Guid, GhabzeGaz, GhabzeGazInputDto, GhabzeGazBatchInsertOutputDto, GhabzeGazOutPutDto>, IGhabzeGazService
    {
        private readonly IRepository<GhabzeGaz, Guid> _repository;

        public GhabzeGazService(IRepository<GhabzeGaz, Guid> repository,
                           IMapper mapper,
                           IComponentContext container,
                           ISystemEventLogService systemEventLogService,
                           IUnitOfWork unitOfWork) : base(mapper, repository, container, systemEventLogService, unitOfWork)
        {
            _repository = repository;
        }
    }
}
