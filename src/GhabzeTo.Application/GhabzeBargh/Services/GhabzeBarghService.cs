using Autofac;
using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Models.GhabzeBargh;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;
using System;

namespace GhabzeTo.Application.Services
{
    public class GhabzeBarghService : ApplicationService<Guid, GhabzeBargh, GhabzeBarghInputDto, GhabzeBarghBatchInsertOutputDto, GhabzeBarghOutPutDto>, IGhabzeBarghService
    {
        private readonly IRepository<GhabzeBargh, Guid> _repository;

        public GhabzeBarghService(IRepository<GhabzeBargh, Guid> repository,
                           IMapper mapper,
                           IComponentContext container,
                           ISystemEventLogService systemEventLogService,
                           IUnitOfWork unitOfWork) : base(mapper, repository, container, systemEventLogService, unitOfWork)
        {
            _repository = repository;
        }
    }
}
