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
    public class AdvertCategoryController : Controller
    {
        IAdvertCategoryService _AdvertCategoryService;
        public AdvertCategoryController(IAdvertCategoryService AdvertCategoryService)
        {
            _AdvertCategoryService = AdvertCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _AdvertCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _AdvertCategoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(AdvertCategory AdvertCategory)
        {
            var result = _AdvertCategoryService.Add(AdvertCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(AdvertCategory AdvertCategory)
        {
            var result = _AdvertCategoryService.Delete(AdvertCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(AdvertCategory AdvertCategory)
        {
            var result = _AdvertCategoryService.Update(AdvertCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
