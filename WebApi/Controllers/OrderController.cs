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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("orderAdd")]
        public IActionResult OrderAdd(Order order)
        {
            var result = _orderService.Add(order);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("orderUpdate")]
        public IActionResult OrderUpdate(Order order)
        {
            var result = _orderService.Update(order);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("orderDelete")]
        public IActionResult OrderDelete(Order order)
        {
            var result = _orderService.Delete(order);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("orderGetAll")]
        public IActionResult OrderGetAll()
        {
            var result = _orderService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("orderById")]
        public IActionResult OrderById(int id)
        {
            var result = _orderService.GetOrderById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("customerById")]
        public IActionResult CustomerById(int customerId)
        {
            var result = _orderService.GetCustomerId(customerId);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("productById")]
        public IActionResult ProductById(int productId)
        {
            var result = _orderService.GetProductId(productId);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("customerByAdress")]
        public IActionResult CustomerByAdress(string adress)
        {
            var result = _orderService.GetCustomerAdress(adress);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("customerDatesorting")]
        public IActionResult Datesorting(DateTime sortingasc, DateTime sortingdesc)
        {
            var result = _orderService.GetDatesorting(sortingasc, sortingdesc);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
