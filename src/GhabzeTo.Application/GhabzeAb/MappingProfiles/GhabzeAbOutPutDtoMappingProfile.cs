using AutoMapper;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Domain.Models.GhabzeAb;

namespace GhabzeTo.Application.MappingProfiles
{
    public class GhabzeAbOutPutDtoMappingProfile : Profile
    {
        public GhabzeAbOutPutDtoMappingProfile()
        {
            CreateMap<GhabzeAb, GhabzeAbOutPutDto>().ReverseMap();
        }
    }
}
