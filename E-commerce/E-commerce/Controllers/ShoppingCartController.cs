﻿using Core.Interfaces;
using Data.ViewModels;
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
    public class ShoppingCartController : ControllerBase
    {
        private readonly ILogger<ShoppingCartController> _logger;
        private IShoppingCartService _shoppingCartService;
        public ShoppingCartController(ILogger<ShoppingCartController> logger, IShoppingCartService shoppingCartService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
        }
        [HttpPost]
        public async Task<IActionResult> ShoppingCartAsync(ShoppingCartVM vm)
        {
            try
            {

            await _shoppingCartService.ShoppingCartAsync(vm);
            return Ok("Successful purchase");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
