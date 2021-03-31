using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models;
using GhabzeTo.Domain.Models.GhabzeTelephone;

namespace GhabzeTo.Application.Services.MappingProfiles
{
    public class GhabzeTelephoneOutPutDtoMappingProfile : Profile
    {
        public GhabzeTelephoneOutPutDtoMappingProfile()
        {
            CreateMap <GhabzeTelephone, GhabzeTelephoneOutPutDto>();
        }
    }
}
