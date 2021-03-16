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
    public class PaymentMethodController : ControllerBase
    {
        private readonly ILogger<PaymentMethodController> _logger;
        private IPaymentMethodService _paymentMethod;
        public PaymentMethodController(ILogger<PaymentMethodController> logger, IPaymentMethodService paymentMethod)
        {
            _logger = logger;
            _paymentMethod = paymentMethod;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_paymentMethod.GetPaymentMethod());
        }
    }
}
