using Business.Abstract;
using Entites.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandevuController : ControllerBase 
	{
        IRandevuService _randevuService;
        public
        RandevuController(IRandevuService randevuService)
        {
            _randevuService = randevuService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _randevuService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Randevu randevu)
        {
            var result = _randevuService.Add(randevu);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Randevu randevu)
        {
            var result = _randevuService.Delete(randevu);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Randevu randevu)
        {
            var result = _randevuService.Update(randevu);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
