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
    public class HistoryOfPaymentsController : ControllerBase
    {
        private readonly ILogger<HistoryOfPaymentsController> _logger;
        private IHistoryOfPaymentsService _historyOfPayments;
        public HistoryOfPaymentsController(ILogger<HistoryOfPaymentsController> logger, IHistoryOfPaymentsService historyOfPayments)
        {
            _logger = logger;
            _historyOfPayments = historyOfPayments;
        }
        [HttpGet]
        public IActionResult Get(string CustomerID)
        {
            return Ok(_historyOfPayments.GetHistoryOfPayments(CustomerID));
        }
    }
}
