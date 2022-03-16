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
    public class SubscriberController : Controller
    {
        ISubscriberService _SubscriberService;
        public SubscriberController(ISubscriberService SubscriberService)
        {
            _SubscriberService = SubscriberService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _SubscriberService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _SubscriberService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Subscriber Subscriber)
        {
            var result = _SubscriberService.Add(Subscriber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Subscriber Subscriber)
        {
            var result = _SubscriberService.Delete(Subscriber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Subscriber Subscriber)
        {
            var result = _SubscriberService.Update(Subscriber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
