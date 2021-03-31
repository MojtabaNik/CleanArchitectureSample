using AutoMapper;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Domain.Models.GhabzeAb;

namespace GhabzeTo.Application.MappingProfile
{
    public class SabegheMianGineMasrafOutPutDtoMappingProfile : Profile
    {
        public SabegheMianGineMasrafOutPutDtoMappingProfile()
        {
            CreateMap<SabegheMianGineMasraf, SabegheMianGineMasrafOutPutDto>().ReverseMap();
        }
    }
}
