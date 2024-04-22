using Business.Abstract;
using Entites.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YorumlarController : ControllerBase
	{
        IYorumlarService _yorumlarService;
        public
        YorumlarController(IYorumlarService yorumlarService)
        {
            _yorumlarService = yorumlarService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _yorumlarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Yorumlar yorumlar)
        {
            var result = _yorumlarService.Add(yorumlar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Yorumlar yorumlar)
        {
            var result = _yorumlarService.Delete(yorumlar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Yorumlar yorumlar)
        {
            var result = _yorumlarService.Update(yorumlar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
} 