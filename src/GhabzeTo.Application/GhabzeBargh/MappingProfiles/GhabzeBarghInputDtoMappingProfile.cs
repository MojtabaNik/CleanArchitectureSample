using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeBargh;

namespace GhabzeTo.Application.Services.MappingProfiles
{
    public class GhabzeBarghInputDtoMappingProfile : Profile
    {
        public GhabzeBarghInputDtoMappingProfile()
        {
            CreateMap<GhabzeBargh, GhabzeBarghInputDto>().ReverseMap();
        }
    }
}
