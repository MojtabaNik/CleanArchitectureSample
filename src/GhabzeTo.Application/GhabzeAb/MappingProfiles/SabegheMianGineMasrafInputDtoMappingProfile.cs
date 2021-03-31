using AutoMapper;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Domain.Models.GhabzeAb;

namespace GhabzeTo.Application.MappingProfile
{
    public class SabegheMianGineMasrafInputDtoMappingProfile : Profile
    {
        public SabegheMianGineMasrafInputDtoMappingProfile()
        {
            CreateMap<SabegheMianGineMasraf, SabegheMianGineMasrafInputDto>().ReverseMap();
        }
    }
}
