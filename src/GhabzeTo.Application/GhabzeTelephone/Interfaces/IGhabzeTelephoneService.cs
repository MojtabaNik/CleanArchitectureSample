using GhabzeTo.Application.Core;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeTelephone;
using System;

namespace GhabzeTo.Application.Interfaces
{
    public interface IGhabzeTelephoneService : IApplicationService<Guid,GhabzeTelephone, GhabzeTelephoneInputDto, GhabzeTelephoneBatchInsertOutputDto, GhabzeTelephoneOutPutDto>
    {
    }
}
