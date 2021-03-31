using AutoMapper;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Domain.Models.GhabzeAb;

namespace GhabzeTo.Application.MappingProfiles
{
    public class GhabzeAbInputDtoMappingProfiles : Profile
    {
        public GhabzeAbInputDtoMappingProfiles()
        {
            CreateMap<GhabzeAb, GhabzeAbInputDto>().ReverseMap();
        }
    }
}
