using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpPost("aboutAdd")]
        public IActionResult AboutAdd(About about)
        {
            var result = _aboutService.Add(about);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("aboutUpdate")]
        public IActionResult AboutUpdate(About about)
        {
            var result = _aboutService.Update(about);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("aboutDelete")]
        public IActionResult AboutDelete(About about)
        {
            var result = _aboutService.Delete(about);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("aboutGetAll")]
        public IActionResult AboutGetAll()
        {
            var result = _aboutService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("aboutById")]
        public IActionResult AboutById(int id)
        {
            var result = _aboutService.GetAboutById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("aboutByDescription")]
        public IActionResult AboutByDescription(string aboutDescription)
        {
            var result = _aboutService.GetAboutByDescription(aboutDescription);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
