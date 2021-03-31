using GhabzeTo.Application.Core;
using System;
using GhabzeTo.Domain.Models.GhabzeAb;
using GhabzeTo.Application.Dtos;

namespace GhabzeTo.Application.Interfaces
{
    public interface IGhabzeAbService : IApplicationService<Guid, GhabzeAb, GhabzeAbInputDto, GhabzeAbBatchInsertOutPutDto, GhabzeAbOutPutDto>
    {
    }
}
