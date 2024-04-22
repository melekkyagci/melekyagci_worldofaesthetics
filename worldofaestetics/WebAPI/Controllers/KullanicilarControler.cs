using Business.Abstract;
using Entites.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullanicilarController : ControllerBase
	{
        IKullanicilarService _kullanicilarService;
        public
        KullanicilarController(IKullanicilarService kullanicilarService)
        {
            _kullanicilarService = kullanicilarService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kullanicilarService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Kullanicilar kullanicilar)
        {
            var result = _kullanicilarService.Add(kullanicilar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Kullanicilar kullanicilar)
        {
            var result = _kullanicilarService.Delete(kullanicilar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Kullanicilar kullanicilar)
        {
            var result = _kullanicilarService.Update(kullanicilar);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}