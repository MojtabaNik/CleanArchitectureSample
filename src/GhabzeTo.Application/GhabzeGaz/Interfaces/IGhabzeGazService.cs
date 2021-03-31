using GhabzeTo.Application.Core;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeGaz;
using System;

namespace GhabzeTo.Application.Interfaces
{
    public interface IGhabzeGazService : IApplicationService<Guid, GhabzeGaz, GhabzeGazInputDto, GhabzeGazBatchInsertOutputDto, GhabzeGazOutPutDto>
    {
    }
}
