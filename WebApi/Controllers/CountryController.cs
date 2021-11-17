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
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost("countryAdd")]
        public IActionResult CountryAdd(Country country)
        {
            var result = _countryService.Add(country);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("countryUpdate")]
        public IActionResult CountryUpdate(Country country)
        {
            var result = _countryService.Update(country);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("countryDelete")]
        public IActionResult CountryDelete(Country country)
        {
            var result = _countryService.Delete(country);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("countryGetAll")]
        public IActionResult CountryGetAll()
        {
            var result = _countryService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("countryById")]
        public IActionResult CountryById(int id)
        {
            var result = _countryService.GetCountryById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("countryByCode")]
        public IActionResult CountryByCode(string code)
        {
            var result = _countryService.GetCountryByCode(code);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }


        [HttpGet("countryByDescription")]
        public IActionResult CountryByDescription(string countryDescription)
        {
            var result = _countryService.GetCountryByName(countryDescription);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
