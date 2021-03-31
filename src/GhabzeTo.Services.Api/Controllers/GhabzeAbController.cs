using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GhabzeTo.Application.Core.DTOs.BatchInsert;
using GhabzeTo.Application.Core.DTOs.SPF;
using GhabzeTo.Application.Dtos;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Services.Api.Infra;
using Microsoft.AspNetCore.Mvc;

namespace GhabzeTo.Services.Api.Controllers
{
    /// <summary>
    /// قبض آب
    /// </summary>
    [Route("api/[controller]")]
    public class GhabzeAbController : BaseApiController
    {
        private readonly IGhabzeAbService _ghabzeAbService;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="ghabzeAbService"></param>
        public GhabzeAbController(IGhabzeAbService ghabzeAbService)
        {
            _ghabzeAbService = ghabzeAbService;
        }

        /// <summary>
        /// Get All Data from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<IEnumerable<GhabzeAbOutPutDto>> Get()
        {
            return _ghabzeAbService.GetAll();
        }

        /// <summary>
        /// Get all data with sort,page,and filtering
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Paging")]
        public SPFOutPutDto<GhabzeAbOutPutDto> Get(SPFInputDto model)
        {
            return _ghabzeAbService.GetAllWithSPF(model);
        }

        /// <summary>
        /// Get one data based on it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Task<GhabzeAbOutPutDto> Get(Guid id)
        {
            return _ghabzeAbService.Get(id);
        }

        /// <summary>
        /// Save a GhabzeAbInputDto model into database.
        /// </summary>
        /// <param name="model">The Dto model that you should pass.</param>
        /// <returns></returns>
        /// <response code="400">Model Validation Faild</response>
        /// <response code="500">Error Message</response>   
        [HttpPost]
        public Task Post([FromBody] GhabzeAbInputDto model)
        {
            return _ghabzeAbService.Create(model);
        }

        /// <summary>
        /// Save List of GhabzeAbInputDto model into database.
        /// </summary>
        /// <param name="model">The Dto model that you should pass.</param>
        /// <returns></returns>
        /// <response code="400">Model Validation Faild</response>
        /// <response code="500">Error Message</response>   
        [HttpPost]
        [Route("BatchInsert")]
        public Task<List<BatchInsertResponseModel<GhabzeAbBatchInsertOutPutDto>>> BatchInsert([FromBody] List<GhabzeAbInputDto> model)
        {
            return _ghabzeAbService.Create(model);
        }

        /// <summary>
        /// Update an input model based on it's id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public Task Put(Guid id, [FromBody] GhabzeAbInputDto model)
        {
            return _ghabzeAbService.Update(id, model);
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public Task Delete(Guid id)
        {
            return _ghabzeAbService.Delete(id);
        }
    }
}
