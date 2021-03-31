using AutoMapper;
using GhabzeTo.Application.DTOs;

namespace GhabzeTo.Application.MappingProfiles
{
    public class GhabzeBarghBatchInsertOutputDtoMappingProfile : Profile
    {
        public GhabzeBarghBatchInsertOutputDtoMappingProfile()
        {
            CreateMap<GhabzeBarghInputDto, GhabzeBarghBatchInsertOutputDto>();
        }
    }
}
