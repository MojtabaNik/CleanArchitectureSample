using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeTelephone;

namespace GhabzeTo.Application.Services.MappingProfiles
{
    public class GhabzeTelephoneInputDtoMappingProfile : Profile
    {
        public GhabzeTelephoneInputDtoMappingProfile()
        {
            CreateMap<GhabzeTelephone, GhabzeTelephoneInputDto>().ReverseMap();
        }
    }
}
