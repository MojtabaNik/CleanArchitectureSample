using Autofac;
using AutoMapper;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Models.GhabzeAb;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;
using System;

namespace GhabzeTo.Application.Services
{
    public class GhabzeAbService : ApplicationService<Guid, GhabzeAb, GhabzeAbInputDto, GhabzeAbBatchInsertOutPutDto, GhabzeAbOutPutDto>, IGhabzeAbService
    {
        #region Ctor
        public GhabzeAbService(
            IMapper mapper,
            IRepository<GhabzeAb, Guid> repository,
            IComponentContext container,
            ISystemEventLogService systemEventLogService,
            IUnitOfWork unitOfWork) : base(
            mapper,
            repository,
            container,
            systemEventLogService,
            unitOfWork)
        {
        }
        #endregion


    }
}
