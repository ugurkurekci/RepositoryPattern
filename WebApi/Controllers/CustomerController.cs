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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("customerAdd")]
        public IActionResult CustomerAdd(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("customerUpdate")]
        public IActionResult CustomerUpdate(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("customerDelete")]
        public IActionResult CustomerDelete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("customerGetAll")]
        public IActionResult CustomerGetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("customerById")]
        public IActionResult CustomerById(int id)
        {
            var result = _customerService.GetCustomerById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("customerByDescription")]
        public IActionResult CustomerByDescription(string customerAdress)
        {
            var result = _customerService.GetByCustomerAdress(customerAdress);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("customerByIdentityNumber")]
        public IActionResult CustomerByIdentityNumber(string customerByIdentityNumber)
        {
            var result = _customerService.GetCustomerByIdentityNumber(customerByIdentityNumber);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("customerByName")]
        public IActionResult CustomerByName(string customerByName)
        {
            var result = _customerService.GetCustomerByName(customerByName);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("customerByPhone")]
        public IActionResult CustomerByPhone(string customerByPhone)
        {
            var result = _customerService.GetCustomerByPhone(customerByPhone);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("customerFullName")]
        public IActionResult CustomerFullName(string firstname, string lastname)
        {
            var result = _customerService.GetCustomerFullName(firstname, lastname);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
