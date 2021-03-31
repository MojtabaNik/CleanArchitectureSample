using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GhabzeTo.Application.Core.DTOs.BatchInsert;
using GhabzeTo.Application.Core.DTOs.SPF;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GhabzeTo.Services.Api.Controllers
{
    /// <summary>
    /// This Controller is for GhabzeGaz purposes
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GhabzeGazController : ControllerBase
    {
        private readonly IGhabzeGazService _GhabzeGazService;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="GhabzeGazService"></param>
        public GhabzeGazController(IGhabzeGazService GhabzeGazService)
        {
            _GhabzeGazService = GhabzeGazService;
        }

        /// <summary>
        /// Get All Data from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<IEnumerable<GhabzeGazOutPutDto>> Get()
        {
            return _GhabzeGazService.GetAll();
        }
        /// <summary>
        /// Get all data with sort,page,and filtering
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Paging")]
        public SPFOutPutDto<GhabzeGazOutPutDto> Get(SPFInputDto model)
        {
            return _GhabzeGazService.GetAllWithSPF(model);
        }

        /// <summary>
        /// Get one data based on it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Task<GhabzeGazOutPutDto> Get(Guid id)
        {
            return _GhabzeGazService.Get(id);
        }

        /// <summary>
        /// Save a GhabzeGaz model Guido database.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Value
        ///     {
        ///        "name": "Mojtaba",
        ///        "family": "Nik"
        ///     }
        ///
        /// </remarks>
        /// <param name="model">The Dto model that you should pass.</param>
        /// <returns></returns>
        /// <response code="400">Model Validation Faild</response>
        /// <response code="500">Error Message</response>   
        [HttpPost]
        public async Task Post([FromBody] GhabzeGazInputDto model)
        {
            await _GhabzeGazService.Create(model);
        }

        /// <summary>
        /// Save a GhabzeGaz model Guido database.
        /// </summary>
        /// <param name="model">The Dto model that you should pass.</param>
        /// <returns></returns>
        /// <response code="400">Model Validation Faild</response>
        /// <response code="500">Error Message</response>   
        [HttpPost]
        [Route("BatchInsert")]
        public async Task<List<BatchInsertResponseModel<GhabzeGazBatchInsertOutputDto>>> BatchInsert([FromBody] List<GhabzeGazInputDto> model)
        {
            return await _GhabzeGazService.Create(model);
        }

        /// <summary>
        /// Update an input model based on it's id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] GhabzeGazInputDto model)
        {
            await _GhabzeGazService.Update(id, model);
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public Task Delete(Guid id)
        {
            return _GhabzeGazService.Delete(id);
        }
    }
}
