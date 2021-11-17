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
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost("cityAdd")]
        public IActionResult CityAdd(City city)
        {
            var result = _cityService.Add(city);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("cityUpdate")]
        public IActionResult CityUpdate(City city)
        {
            var result = _cityService.Update(city);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("cityDelete")]
        public IActionResult CityDelete(City city)
        {
            var result = _cityService.Delete(city);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("cityGetAll")]
        public IActionResult CityGetAll()
        {
            var result = _cityService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("cityById")]
        public IActionResult CityById(int id)
        {
            var result = _cityService.GetCityById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("cityByDescription")]
        public IActionResult CityByDescription(string cityDescription)
        {
            var result = _cityService.GetCityByName(cityDescription);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
