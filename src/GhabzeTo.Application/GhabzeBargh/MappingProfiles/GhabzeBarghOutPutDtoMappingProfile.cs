using AutoMapper;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Domain.Models.GhabzeBargh;

namespace GhabzeTo.Application.Services.MappingProfiles
{
    public class GhabzeBarghOutPutDtoMappingProfile : Profile
    {
        public GhabzeBarghOutPutDtoMappingProfile()
        {
            CreateMap<GhabzeBargh, GhabzeBarghOutPutDto>();
        }
    }
}
