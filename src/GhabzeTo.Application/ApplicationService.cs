using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using GhabzeTo.Application.Core;
using GhabzeTo.Application.Core.DTOs.BatchInsert;
using GhabzeTo.Application.Core.DTOs.SPF;
using GhabzeTo.Application.Core.Exceptions;
using GhabzeTo.Application.Core.Extensions;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Core;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;
using GhabzeTo.Infra.Resources.SystemErrors;
using GhabzeTo.Infra.Resources.SystemMessages;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application
{
    public abstract class ApplicationService<TPrimaryKey, TEntity, InputDto, BatchInsertOutputDto, OutputDto> :
        IApplicationService<TPrimaryKey, TEntity, InputDto, BatchInsertOutputDto, OutputDto> where TEntity : class, IEntity<TPrimaryKey>
    {
        protected readonly IMapper _mapper;
        private readonly IRepository<TEntity, TPrimaryKey> _repository;
        private readonly IComponentContext _container;
        protected readonly IUnitOfWork _unitOfWork;
        private readonly ISystemEventLogService _systemEventLogService;

        public ApplicationService(IMapper mapper,
                                  IRepository<TEntity, TPrimaryKey> repository,
                                  IComponentContext container,
                                  ISystemEventLogService systemEventLogService,
                                  IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _repository = repository;
            _container = container;
            _unitOfWork = unitOfWork;
            _systemEventLogService = systemEventLogService;
        }

        public virtual async Task<bool> Create(InputDto inputDto)
        {
            throw new ArgumentNullException();
            var dbModel = _mapper.Map<TEntity>(inputDto);
            await _repository.InsertAsync(dbModel).ConfigureAwait(false);

            try
            {

                var res = await _unitOfWork.SaveChangesAsync();
                return res != 0;
            }
            catch (Exception)
            {
                throw new UserFriendlyException(SystemErrorResourceKeys.DatabaseSaveChangesException);
            }
        }

        public virtual async Task<List<BatchInsertResponseModel<BatchInsertOutputDto>>> Create(List<InputDto> model)
        {
            if (model.Count <= 0)
            {
                throw new ValidationException(new List<ValidationFailure>() {
                    new ValidationFailure("RequestBody",ValidationResourceKeys.RequestBodyNull)
                });
            }

            var result = new List<BatchInsertResponseModel<BatchInsertOutputDto>>();

            var firstItem = model.FirstOrDefault();
            var validatorType = firstItem.GetValidator();
            IValidator validatorInstance = null;
            if (validatorType != null)
            {
                validatorInstance = (IValidator)_container.Resolve(validatorType);
            }

            var addedList = model.Select(item =>
              {
                  var batchInsertResponseModel = new BatchInsertResponseModel<BatchInsertOutputDto>() { Item = _mapper.Map<BatchInsertOutputDto>(item) };

                  if (validatorType != null && validatorInstance != null)
                  {
                      var validator = validatorInstance.Validate(item);

                      if (!validator.IsValid)
                      {
                          var dic = new Dictionary<string, string>();
                          foreach (var error in validator.Errors)
                          {
                              if (!dic.ContainsKey(error.PropertyName))
                              {
                                  dic.Add(error.PropertyName.ToLower(),
                                      string.Join(",",
                                          validator.Errors.Where(x => x.PropertyName == error.PropertyName)
                                              .Select(x => x.ErrorMessage)));
                              }
                          }

                          ;

                          batchInsertResponseModel.Result = validator.IsValid;
                          batchInsertResponseModel.Message = dic;
                          result.Add(batchInsertResponseModel);
                          return null;
                      }
                  }

                  batchInsertResponseModel.Result = true;
                  batchInsertResponseModel.Message = SystemMessagesResourceKeys.SuccessMessage;
                  result.Add(batchInsertResponseModel);
                  return _mapper.Map<TEntity>(item);
              }).Where(x => x != null).ToList();

            try
            {
                await _repository.BulkInsertAsync(addedList).ConfigureAwait(false);
                await _unitOfWork.BulkSaveChangeAsync();
            }
            catch
            {
                throw new UserFriendlyException(SystemErrorResourceKeys.DatabaseSaveChangesException);
            }

            return result;
        }

        public virtual async Task<bool> Delete(TPrimaryKey id)
        {
            var dbModel = await _repository.GetAsync(id);
            if (dbModel == null)
            {
                throw new EntityNotFoundException();
            }

            dbModel.IsDelete = true;
            await _repository.UpdateAsync(dbModel).ConfigureAwait(false);
            var res = await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return res != 0;
        }

        public virtual async Task<OutputDto> Get(TPrimaryKey id)
        {
            var dbModel = await _repository.GetAsync(id);
            if (dbModel == null || dbModel.IsDelete)
                throw new EntityNotFoundException();

            return _mapper.Map<OutputDto>(dbModel);
        }

        public virtual async Task<IEnumerable<OutputDto>> GetAll()
        {
            var dbResult = await _repository.GetAllListAsync();
            return _mapper.Map<IEnumerable<OutputDto>>(dbResult.Where(x => !x.IsDelete));
        }

        public virtual SPFOutPutDto<OutputDto> GetAllWithSPF(SPFInputDto model)
        {
            var dbResult = _repository.GetAll().Where(x => !x.IsDelete);
            var res = _mapper.ProjectTo<OutputDto>(dbResult).SPF(model, out long totalRecord).ToList();
            return new SPFOutPutDto<OutputDto>()
            {
                ShowRecord = res.Count,
                ResultList = res,
                TotalRecord = totalRecord
            };
        }

        public virtual async Task Update(TPrimaryKey id, InputDto inputDto)
        {
            var dbModel = await _repository.GetAsync(id).ConfigureAwait(false);
            if (dbModel == null)
            {
                throw new EntityNotFoundException();
            }

            _mapper.Map(inputDto, dbModel);

            //Set Modified Date
            if (dbModel.GetType().BaseType.IsGenericType && dbModel.GetType().BaseType.GetGenericTypeDefinition() == typeof(AuditableEntity<>))
            {
                ((IAuditableEntity<TPrimaryKey>)dbModel).ModifiedDate = DateTime.Now;
            }
            else if (dbModel.GetType().BaseType == typeof(AuditableEntity))
            {
                ((IAuditableEntity)dbModel).ModifiedDate = DateTime.Now;
            }

            await _repository.UpdateAsync(dbModel).ConfigureAwait(false);
            var res = await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            if (res == 0)
            {
                throw new UserFriendlyException(SystemErrorResourceKeys.DatabaseSaveChangesException);
            }
        }
    }
}
