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
    public class BlogController : Controller
    {
        IBlogService _BlogService;
        public BlogController(IBlogService BlogService)
        {
            _BlogService = BlogService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _BlogService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _BlogService.GetAllDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalldetailsbycategory")]
        public IActionResult GetAllDetailsByCategory(int categoryId)
        {
            var result = _BlogService.GetAllDetailsByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalldetailsbyid")]
        public IActionResult GetAllDetailsById(int id)
        {
            var result = _BlogService.GetAllDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _BlogService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Blog Blog)
        {
            var result = _BlogService.Add(Blog);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Blog Blog)
        {
            var result = _BlogService.Delete(Blog);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Blog Blog)
        {
            var result = _BlogService.Update(Blog);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
