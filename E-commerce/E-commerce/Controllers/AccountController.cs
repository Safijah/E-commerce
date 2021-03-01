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
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
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
        private IEmailService _emailService;
        private IConfiguration _configuration;

        public AccountController(UserManager<Account> userManager,  RoleManager<IdentityRole> roleManager,
            ICustomerService customerService, IOptions<AccountSettings> accSettings,IEmailService emailService, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _customerService = customerService;
            _accSettings = accSettings.Value;
            _emailService = emailService;
            _configuration = configuration;

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
                    var confirmEmailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var encodedEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);
                    var validEmailToken = WebEncoders.Base64UrlEncode(encodedEmailToken);

                    string url = $"{_configuration["AppUrl"]}/account/confirmemail?userid={user.Id}&token={validEmailToken}";

                    await _emailService.SendEmailAsync(user.Email, "Confirm your email", $"<h1>Hi,</h1>" +
                        $"<p>Please confirm your email by <a href='{url}'>Clicking here</a></p>");

                    return Ok(new { message= "User created successfully!" }); // Status Code: 200 
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
                await _emailService.SendEmailAsync(model.Email, "New login", "<h1>Hey!, new login to your account noticed</h1><p>New login to your account at " + DateTime.Now + "</p>");
                return Ok(new { token });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
        }
        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
                return NotFound();

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
              return  BadRequest("User not found");
            }
                   
               

            var decodedToken = WebEncoders.Base64UrlDecode(token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManager.ConfirmEmailAsync(user, normalToken);

            if (result.Succeeded)
            {
                return Ok("Email confirmed successfully!");
            }

            return BadRequest("Email did not confirm");
        }
    }
}
