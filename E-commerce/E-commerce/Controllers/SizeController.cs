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
    public class SizeController : ControllerBase
    {
        private readonly ILogger<SizeController> _logger;
        private ISizeService _sizeService;
        public SizeController(ILogger<SizeController> logger, ISizeService sizeService)
        {
            _logger = logger;
            _sizeService = sizeService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sizeService.GetAll());
        }
    }
}
