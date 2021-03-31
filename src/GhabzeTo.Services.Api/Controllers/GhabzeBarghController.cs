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
    /// This Controller is for GhabzeBargh purposes
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GhabzeBarghController : ControllerBase
    {
        private readonly IGhabzeBarghService _GhabzeBarghService;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="GhabzeBarghService"></param>
        public GhabzeBarghController(IGhabzeBarghService GhabzeBarghService)
        {
            _GhabzeBarghService = GhabzeBarghService;
        }

        /// <summary>
        /// Get All Data from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<IEnumerable<GhabzeBarghOutPutDto>> Get()
        {
            return _GhabzeBarghService.GetAll();
        }
        /// <summary>
        /// Get all data with sort,page,and filtering
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Paging")]
        public SPFOutPutDto<GhabzeBarghOutPutDto> Get(SPFInputDto model)
        {
            return _GhabzeBarghService.GetAllWithSPF(model);
        }

        /// <summary>
        /// Get one data based on it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Task<GhabzeBarghOutPutDto> Get(Guid id)
        {
            return _GhabzeBarghService.Get(id);
        }

        /// <summary>
        /// Save a GhabzeBargh model into database.
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
        public Task Post([FromBody] GhabzeBarghInputDto model)
        {
            return _GhabzeBarghService.Create(model);
        }

        /// <summary>
        /// Save a GhabzeBargh model into database.
        /// </summary>
        /// <param name="model">The Dto model that you should pass.</param>
        /// <returns></returns>
        /// <response code="400">Model Validation Faild</response>
        /// <response code="500">Error Message</response>   
        [HttpPost]
        [Route("BatchInsert")]
        public Task<List<BatchInsertResponseModel<GhabzeBarghBatchInsertOutputDto>>> BatchInsert([FromBody] List<GhabzeBarghInputDto> model)
        {
            return _GhabzeBarghService.Create(model);
        }

        /// <summary>
        /// Update an input model based on it's id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public Task Put(Guid id, [FromBody] GhabzeBarghInputDto model)
        {
            return _GhabzeBarghService.Update(id, model);
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public Task Delete(Guid id)
        {
            return _GhabzeBarghService.Delete(id);
        }
    }
}
