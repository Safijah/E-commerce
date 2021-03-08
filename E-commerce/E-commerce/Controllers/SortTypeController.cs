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
    public class SortTypeController : ControllerBase
    {
        private readonly ILogger<SortTypeController> _logger;
        private ISortTypeService _sortTypeService;
        public SortTypeController(ILogger<SortTypeController> logger, ISortTypeService sortTypeService)
        {
            _logger = logger;
            _sortTypeService = sortTypeService;
        }
        [HttpGet]
        public IActionResult GetSortType()
        {
            return Ok(_sortTypeService.GetSortType());
        }
    }
}
