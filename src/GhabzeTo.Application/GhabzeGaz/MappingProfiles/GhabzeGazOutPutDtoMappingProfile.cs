using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeGaz;

namespace GhabzeTo.Application.Services.MappingProfiles
{
    public class GhabzeGazOutPutDtoMappingProfile : Profile
    {
        public GhabzeGazOutPutDtoMappingProfile()
        {
            CreateMap <GhabzeGaz, GhabzeGazOutPutDto>();
        }
    }
}
