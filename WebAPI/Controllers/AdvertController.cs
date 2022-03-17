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
    public class AdvertController : Controller
    {
        IAdvertService _AdvertService;
        public AdvertController(IAdvertService AdvertService)
        {
            _AdvertService = AdvertService;
        }
        [HttpGet("getallbyasc")]
        public IActionResult GetAllAdvertsByAsc()
        {
            var result = _AdvertService.GetAllAdvertsByAsc();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _AdvertService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _AdvertService.GetAllDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalldetailsbycategory")]
        public IActionResult GetAllDetailsByCategory(int categoryId)
        {
            var result = _AdvertService.GetAllDetailsByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalldetailsbyid")]
        public IActionResult GetAllDetailsById(int id)
        {
            var result = _AdvertService.GetAllDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _AdvertService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Advert advert)
        {
            var result = _AdvertService.Add(advert);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Advert advert)
        {
            var result = _AdvertService.Delete(advert);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Advert advert)
        {
            var result = _AdvertService.Update(advert);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
