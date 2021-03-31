using AutoMapper;
using GhabzeTo.Application.Dtos;

namespace GhabzeTo.Application.MappingProfiles
{
    public class GhabzeAbBatchInsertOutputDtoMappingProfile : Profile
    {
        public GhabzeAbBatchInsertOutputDtoMappingProfile()
        {
            CreateMap<GhabzeAbInputDto, GhabzeAbBatchInsertOutPutDto>().ReverseMap();
        }
    }
}
