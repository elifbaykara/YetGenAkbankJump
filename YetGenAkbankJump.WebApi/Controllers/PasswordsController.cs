﻿using Lecture_4_2.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YetGenAkbankJump.Shared.Services;
using YetGenAkbankJump.Shared.Utilities;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordsController : ControllerBase
    {
        private PasswordGenerator _passwordGenerator;
        private readonly RequestCountService _requestCountService;
        private readonly TextService _textService;

        public PasswordsController(PasswordGenerator passwordGenerator, RequestCountService requestCountService, TextService textService)
        {
            _passwordGenerator = passwordGenerator;
            _requestCountService = requestCountService;
            _textService = textService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_passwordGenerator.Generate(12, true, true, true, true));
        }


        [HttpGet("GetCount")]
        public IActionResult GetCount()
        {
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
