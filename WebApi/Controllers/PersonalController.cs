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
    public class PersonalController : ControllerBase
    {
        private readonly IPersonalService _personalService;

        public PersonalController(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        [HttpPost("personalAdd")]
        public IActionResult PersonalAdd(Personal personal)
        {
            var result = _personalService.Add(personal);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("personalUpdate")]
        public IActionResult PersonalUpdate(Personal personal)
        {
            var result = _personalService.Update(personal);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("personalDelete")]
        public IActionResult PersonalDelete(Personal personal)
        {
            var result = _personalService.Delete(personal);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("personalGetAll")]
        public IActionResult PersonalGetAll()
        {
            var result = _personalService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("personalById")]
        public IActionResult PersonalById(int id)
        {
            var result = _personalService.GetPersonalById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("personalByFirstNameByLastName")]
        public IActionResult personalByDescription(string personalFirstName, string personalLastName)
        {
            var result = _personalService.GetPersonalByFirstNameandLastName(personalFirstName, personalLastName);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("personalByIdentityNumber")]
        public IActionResult PersonalByIdentityNumber(string IdentityNumber)
        {
            var result = _personalService.GetPersonalByIdentityNumber(IdentityNumber);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("personalByPhone")]
        public IActionResult PersonalByPhone(string Phone)
        {
            var result = _personalService.GetPersonalByPhone(Phone);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("personalByReferanceName")]
        public IActionResult PersonalByReferanceName(string ReferanceName)
        {
            var result = _personalService.GetPersonalByReferanceName(ReferanceName);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("personalByWageScala")]
        public IActionResult PersonalByWageScala(double personalWageScalaMin, double personalWageScalaMax)
        {
            var result = _personalService.GetPersonalWageScala(personalWageScalaMin, personalWageScalaMax);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
