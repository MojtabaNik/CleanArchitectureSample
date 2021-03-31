using AutoMapper;
using GhabzeTo.Application.DTOs;

namespace GhabzeTo.Application.MappingProfiles
{
    public class GhabzeGazBatchInsertOutputDtoMappingProfile : Profile
    {
        public GhabzeGazBatchInsertOutputDtoMappingProfile()
        {
            CreateMap<GhabzeGazInputDto, GhabzeGazBatchInsertOutputDto>();
        }
    }
}
