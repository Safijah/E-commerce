using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Data.EntityModels;
using Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace E_commerce.Controllers
{
    [Route("[controller]")]   
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<Account> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ICustomerService _customerService;
        private readonly AccountSettings _accSettings;
       
        public AccountController(UserManager<Account> userManager,  RoleManager<IdentityRole> roleManager,
            ICustomerService customerService, IOptions<AccountSettings> accSettings)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _customerService = customerService;
            _accSettings = accSettings.Value;
         

        }
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterVM model)
        {
            if (model == null)
                throw new NullReferenceException("Register model is null");
            if (ModelState.IsValid)
            {
                var role = _roleManager.FindByIdAsync("4").Result;
                var user = new Account
                {
                    UserName = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,



                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    var roleResult = await _userManager.AddToRoleAsync(user, role.Name);
                    if (!roleResult.Succeeded)
                        throw new NullReferenceException("Role is not good");
                    Customer customer = new Customer();
                    customer.Account = user;
                    _customerService.AddCustomer(customer);

                    return Ok(result); // Status Code: 200 
                }


                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid"); // Status code: 400
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginVM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest(new { message = "There is no user with that Email address." });
               
            }
                if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID",user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_accSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
        }
    }
}
