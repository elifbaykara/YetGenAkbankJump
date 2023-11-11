using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Reflection.Metadata.Ecma335;
using YetGenAkbankJump.Shared.Helpers;
using YetGenAkbankJump.WebApi.Data;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IStringLocalizer<CommonTranslations> _localizer;

        public CarsController(IStringLocalizer<CommonTranslations> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = CarsContext.LuxuryCars.ToList();
            return Ok(cars);
        }

        [HttpGet("WelcomeMessage")]
        public IActionResult WelcomeMessage() 
        {
            return Ok(_localizer["WelcomeMessage"]);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            if(id == Guid.Empty)
                return BadRequest(_localizer["IdCannotBeNull"]); //400

            var car = CarsContext.LuxuryCars.FirstOrDefault(x => x.Id == id);

            if (car is null)
                return NotFound("The car requested with given Id was not found"); //404

            return Ok(car);
        }
    }
}
