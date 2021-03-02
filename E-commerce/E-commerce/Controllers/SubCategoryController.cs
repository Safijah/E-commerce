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
    public class SubCategoryController : ControllerBase
    {
        private readonly ILogger<SubCategoryController> _logger;
        private ISubCategoryService _subCategoryService;
        public SubCategoryController(ILogger<SubCategoryController> logger, ISubCategoryService subCategoryService)
        {
            _logger = logger;
            _subCategoryService = subCategoryService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_subCategoryService.GetAll());
        }
       
        [HttpGet("{id}")]
        public IActionResult GetByGenderId(int id)
        {
            return Ok(_subCategoryService.GetSubCategory(id));
        }
    }
}
