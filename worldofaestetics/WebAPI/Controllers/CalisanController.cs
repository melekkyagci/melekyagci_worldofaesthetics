
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography.X509Certificates;
using Entites.Concrate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalisanController : ControllerBase 
	{
        ICalisanService _calisanlarService;
        public  CalisanController(ICalisanService calisanService)
        {
            _calisanlarService = calisanService; 
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _calisanlarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Calisan calisanlar)
        {
            var result = _calisanlarService.Add(calisanlar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Calisan calisanlar)
        {
            var result = _calisanlarService.Delete(calisanlar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
         [HttpPost("Update")]
        public IActionResult Update(Calisan calisanlar)
        {
            var result = _calisanlarService.Update(calisanlar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
