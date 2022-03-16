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
    public class BlogImageController : Controller
    {
        IBlogImageService _BlogImageService;

        public BlogImageController(IBlogImageService BlogImageService)
        {
            _BlogImageService = BlogImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _BlogImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _BlogImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("add")]

        public IActionResult Add([FromForm] BlogImage BlogImage, IFormFile file)
        {
            var result = _BlogImageService.Add(BlogImage, file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var BlogImage = _BlogImageService.GetById(Id).Data;
            var result = _BlogImageService.Delete(BlogImage);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var BlogImage = _BlogImageService.GetById(Id).Data;
            var result = _BlogImageService.Update(file, BlogImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
