using GhabzeTo.Application.Interfaces;
using GhabzeTo.Services.Api.Infra;
using Microsoft.AspNetCore.Mvc;

namespace GhabzeTo.Services.Api.Controllers
{
    /// <summary>
    /// This Controller is for test purposes
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HelperController : BaseApiController
    {
        private readonly IFakeDataService _fakeDataService;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="fakeDataService"></param>
        public HelperController(IFakeDataService fakeDataService)
        {
            _fakeDataService = fakeDataService;
        }

        /// <summary>
        /// Fake Json Generator For System Models
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FakeJson")]
        public object GetFakeJson(int numberOfObjects, string dtoName)
        {
            return _fakeDataService.GetFakeObject(numberOfObjects, dtoName);
        }
    }
}
