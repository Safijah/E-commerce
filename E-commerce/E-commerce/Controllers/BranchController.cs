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
    public class BranchController : ControllerBase
    {
        private readonly ILogger<BranchController> _logger;
        private IBranchService _branchService;
        public BranchController(ILogger<BranchController> logger, IBranchService branchService)
        {
            _logger = logger;
            _branchService = branchService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_branchService.GetAll());
            }
            catch (Exception)
            {
                return BadRequest("Branch not found");
            }
        }
    }
}
