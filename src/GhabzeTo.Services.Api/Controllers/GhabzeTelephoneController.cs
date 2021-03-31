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
    /// This Controller is for GhabzeTelephone purposes
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GhabzeTelephoneController : ControllerBase
    {
        private readonly IGhabzeTelephoneService _GhabzeTelephoneService;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="GhabzeTelephoneService"></param>
        public GhabzeTelephoneController(IGhabzeTelephoneService GhabzeTelephoneService)
        {
            _GhabzeTelephoneService = GhabzeTelephoneService;
        }

        /// <summary>
        /// Get All Data from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<GhabzeTelephoneOutPutDto>> Get()
        {
            return await _GhabzeTelephoneService.GetAll();
        }
        /// <summary>
        /// Get all data with sort,page,and filtering
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Paging")]
        public SPFOutPutDto<GhabzeTelephoneOutPutDto> Get(SPFInputDto model)
        {
            return _GhabzeTelephoneService.GetAllWithSPF(model);
        }

        /// <summary>
        /// Get one data based on it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<GhabzeTelephoneOutPutDto> Get(Guid id)
        {
            return await _GhabzeTelephoneService.Get(id);
        }

        /// <summary>
        /// Save a GhabzeTelephone model into database.
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
        public async Task Post([FromBody] GhabzeTelephoneInputDto model)
        {
            await _GhabzeTelephoneService.Create(model);
        }

        /// <summary>
        /// Save a GhabzeTelephone model into database.
        /// </summary>
        /// <param name="model">The Dto model that you should pass.</param>
        /// <returns></returns>
        /// <response code="400">Model Validation Faild</response>
        /// <response code="500">Error Message</response>   
        [HttpPost]
        [Route("BatchInsert")]
        public async Task<List<BatchInsertResponseModel<GhabzeTelephoneBatchInsertOutputDto>>> BatchInsert([FromBody] List<GhabzeTelephoneInputDto> model)
        {
            return await _GhabzeTelephoneService.Create(model);
        }

        /// <summary>
        /// Update an input model based on it's id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] GhabzeTelephoneInputDto model)
        {
            await _GhabzeTelephoneService.Update(id, model);
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _GhabzeTelephoneService.Delete(id);
        }
    }
}
