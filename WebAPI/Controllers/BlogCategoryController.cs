using Busines.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoryController : Controller
    {
        IBlogCategoryService _BlogCategoryService;
        public BlogCategoryController(IBlogCategoryService BlogCategoryService)
        {
            _BlogCategoryService = BlogCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _BlogCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _BlogCategoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(BlogCategory BlogCategory)
        {
            var result = _BlogCategoryService.Add(BlogCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(BlogCategory BlogCategory)
        {
            var result = _BlogCategoryService.Delete(BlogCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(BlogCategory BlogCategory)
        {
            var result = _BlogCategoryService.Update(BlogCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
