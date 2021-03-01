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
    public class GenderCategoryController : ControllerBase
    {
        private readonly ILogger<GenderCategoryController> _logger;
        private IGenderCategoryService _genderCategoryService;
        public GenderCategoryController(ILogger<GenderCategoryController> logger, IGenderCategoryService genderCategoryService)
        {
            _logger = logger;
            _genderCategoryService = genderCategoryService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_genderCategoryService.GetAll());
        }
    }
}
