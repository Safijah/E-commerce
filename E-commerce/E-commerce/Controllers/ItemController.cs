using Core.Interfaces;
using Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private readonly ILogger<ItemController> _logger;
        private IItemService _itemService;
        public ItemController(ILogger<ItemController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;

        }
        [HttpPost]
      
        public IActionResult Get(ItemFilterVM filter)
        {
            try
            {

            return Ok(_itemService.GetAll(filter));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           
                return Ok(_itemService.GetItem(id));
          

        }
        [HttpGet]
        [Route("GetBySearch")]
        public IActionResult Get(string search)
        {
            return Ok(_itemService.GetBySearch(search));
        }

        [HttpPost]
        [Route("GetByFilter")]
        public IActionResult Get(List<FilterVM> filter)
        {
            return Ok(_itemService.GetItem(filter));
        }

    }
}
