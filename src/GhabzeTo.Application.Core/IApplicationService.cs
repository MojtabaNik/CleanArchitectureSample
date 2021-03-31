using GhabzeTo.Application.Core.DTOs.BatchInsert;
using GhabzeTo.Application.Core.DTOs.SPF;
using GhabzeTo.Domain.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GhabzeTo.Application.Core
{
    public interface IApplicationService<TEntity, InputDto, BatchInsertOutputDto, OutputDto> :
        IApplicationService<int, TEntity, InputDto, BatchInsertOutputDto, OutputDto> where TEntity : class, IEntity<int>
    {

    }

    public interface IApplicationService<TPrimaryKey, TEntity, InputDto, BatchInsertOutputDto, OutputDto> where TEntity : class, IEntity<TPrimaryKey>
    {
        Task<bool> Create(InputDto testInputDto);
        Task<List<BatchInsertResponseModel<BatchInsertOutputDto>>> Create(List<InputDto> model);
        Task Update(TPrimaryKey id, InputDto testInputDto);
        Task<IEnumerable<OutputDto>> GetAll();
        SPFOutPutDto<OutputDto> GetAllWithSPF(SPFInputDto model);
        Task<OutputDto> Get(TPrimaryKey id);
        Task<bool> Delete(TPrimaryKey id);
    }
}
