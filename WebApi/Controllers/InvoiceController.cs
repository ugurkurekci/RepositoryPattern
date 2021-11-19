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
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        [HttpPost("invoiceAdd")]
        public IActionResult InvoiceAdd(Invoice invoice)
        {
            var result = _invoiceService.Add(invoice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("invoiceUpdate")]
        public IActionResult InvoiceUpdate(Invoice invoice)
        {
            var result = _invoiceService.Update(invoice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("invoiceDelete")]
        public IActionResult InvoiceDelete(Invoice invoice)
        {
            var result = _invoiceService.Delete(invoice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("invoiceGetAll")]
        public IActionResult InvoiceGetAll()
        {
            var result = _invoiceService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("invoiceById")]
        public IActionResult InvoiceById(int id)
        {
            var result = _invoiceService.GetInvoiceById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("invoiceByName")]
        public IActionResult InvoiceByName(string invoiceByName)
        {
            var result = _invoiceService.GetInvoiceByName(invoiceByName);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("invoiceByDate")]
        public IActionResult InvoiceByDate(DateTime invoiceByDate)
        {
            var result = _invoiceService.GetInvoiceByDate(invoiceByDate);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
