using AutoMapper;
using GhabzeTo.Application.DTOs;

namespace GhabzeTo.Application.MappingProfiles
{
    public class GhabzeTelephoneBatchInsertOutputDtoMappingProfile : Profile
    {
        public GhabzeTelephoneBatchInsertOutputDtoMappingProfile()
        {
            CreateMap<GhabzeTelephoneInputDto, GhabzeTelephoneBatchInsertOutputDto>();
        }
    }
}
