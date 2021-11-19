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
    public class RankController : ControllerBase
    {
        private readonly IRankService _rankService;

        public RankController(IRankService rankService)
        {
            _rankService = rankService;
        }

        [HttpPost("rankAdded")]
        public IActionResult RankAdd(Rank rank)
        {
            var result = _rankService.Add(rank);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("rankUpdate")]
        public IActionResult RankUpdate(Rank rank)
        {
            var result = _rankService.Update(rank);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("rankDelete")]
        public IActionResult RankDelete(Rank rank)
        {
            var result = _rankService.Delete(rank);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("rankGetAll")]
        public IActionResult RankGetAll()
        {
            var result = _rankService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("rankById")]
        public IActionResult RankById(int id)
        {
            var result = _rankService.GetRankById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("rankName")]
        public IActionResult RankByDescription(string rankName)
        {
            var result = _rankService.GetRankByName(rankName);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
