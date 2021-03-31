using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeGaz;

namespace GhabzeTo.Application.Services.MappingProfiles
{
    public class GhabzeGazInputDtoMappingProfile : Profile
    {
        public GhabzeGazInputDtoMappingProfile()
        {
            CreateMap<GhabzeGaz, GhabzeGazInputDto>().ReverseMap();
        }
    }
}
