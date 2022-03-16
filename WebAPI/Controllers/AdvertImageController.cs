using Busines.Abstract;
using Entity.Concrete;
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
    public class AdvertImageController : Controller
    {
        IAdvertImageService _AdvertImageService;

        public AdvertImageController(IAdvertImageService AdvertImageService)
        {
            _AdvertImageService = AdvertImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _AdvertImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _AdvertImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("add")]

        public IActionResult Add([FromForm] AdvertImage AdvertImage, IFormFile file)
        {
            var result = _AdvertImageService.Add(AdvertImage, file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var AdvertImage = _AdvertImageService.GetById(Id).Data;
            var result = _AdvertImageService.Delete(AdvertImage);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var AdvertImage = _AdvertImageService.GetById(Id).Data;
            var result = _AdvertImageService.Update(file, AdvertImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
