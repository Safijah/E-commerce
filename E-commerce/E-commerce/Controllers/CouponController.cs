using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ILogger<CouponController> _logger;
        private ICouponService _couponService;
        public CouponController(ILogger<CouponController> logger, ICouponService couponService)
        {
            _logger = logger;
            _couponService = couponService;
        }
        [HttpGet]
        public IActionResult Get(string code)
        {
            if (_couponService.CheckCode(code))
                return Ok("Code is valid");
            else
                return BadRequest("Code is invalid");
              
           
        }
        [HttpGet]
        [Route("GenerateCode")]
        public IActionResult Get()
        {
            return Ok(_couponService.GenerateChode());


        }

    }
}
