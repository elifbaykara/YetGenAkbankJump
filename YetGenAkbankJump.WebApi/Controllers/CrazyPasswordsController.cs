using Lecture_4_2.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using YetGenAkbankJump.Shared.Helpers;
using YetGenAkbankJump.Shared.Utilities;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrazyPasswordsController : ControllerBase
    {
        private readonly PasswordGenerator _passwordGenerator;
        private readonly RequestCountService _requestCountService;
        private readonly IStringLocalizer<CommonTranslations> _localizer;


        public CrazyPasswordsController(PasswordGenerator passwordGenerator, RequestCountService requestCountService)
        {
            _passwordGenerator = passwordGenerator;
            _requestCountService = requestCountService;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            _requestCountService.Count += 1;

            return Ok(_passwordGenerator.Generate(12, true, true, true, true));
        }


        [HttpGet("GetCount")]
        public IActionResult GetCount() 
        {
            _requestCountService.Count += 1;
            return Ok(_passwordGenerator.GeneratedPasswordsCount);
        }


        [HttpGet("GetRequestCount")]
        public IActionResult GetRequestCount()
        {
            _requestCountService.Count += 1;
            return Ok(_requestCountService.Count);
        }
    }
}
