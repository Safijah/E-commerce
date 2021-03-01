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
    public class BrandCategoryController : ControllerBase
    {
        private readonly ILogger<BrandCategoryController> _logger;
        private IBrandCategoryService _brandCategoryService;
        public BrandCategoryController(ILogger<BrandCategoryController> logger, IBrandCategoryService brandCategoryService)
        {
            _logger = logger;
            _brandCategoryService = brandCategoryService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandCategoryService.GetAll());
        }
    }
}
