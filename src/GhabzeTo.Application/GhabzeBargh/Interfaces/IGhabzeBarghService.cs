using GhabzeTo.Application.Core;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeBargh;
using System;

namespace GhabzeTo.Application.Interfaces
{
    public interface IGhabzeBarghService : IApplicationService<Guid, GhabzeBargh, GhabzeBarghInputDto, GhabzeBarghBatchInsertOutputDto, GhabzeBarghOutPutDto>
    {
    }
}
