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
using E_commerce.ViewModels;
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
        private ICouponService _couponService;
        public AccountController(UserManager<Account> userManager,  RoleManager<IdentityRole> roleManager,
            ICustomerService customerService, IOptions<AccountSettings> accSettings,IEmailService emailService, IConfiguration configuration, ICouponService couponService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _customerService = customerService;
            _accSettings = accSettings.Value;
            _emailService = emailService;
            _configuration = configuration;
            _couponService = couponService;

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
        [HttpPost]
        [Route("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
                return NotFound();

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return BadRequest("No user associated with email");
               

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var encodedToken = Encoding.UTF8.GetBytes(token);
            var validToken = WebEncoders.Base64UrlEncode(encodedToken);

            //string url = $"{_configuration["AppUrl"]}/ResetPassword?email={email}&token={validToken}";

            await _emailService.SendEmailAsync(email, "Reset Password", "<h1>Follow the instructions to reset your password</h1>" +
                $"<p>To reset your password <a href='http://localhost:3000/Registration'>Click here</a></p>");
            return Ok("Reset password URL has been sent to the email successfully!");


        }
        [HttpPost]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordVM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return BadRequest("No user associated with email");
                

            if (model.NewPassword != model.ConfirmPassword)
                  return BadRequest("Password doesn't match its confirmation");
            if(ModelState.IsValid)
            {
                var decodedToken = WebEncoders.Base64UrlDecode(model.Token);
                string normalToken = Encoding.UTF8.GetString(decodedToken);

                var result = await _userManager.ResetPasswordAsync(user, normalToken, model.NewPassword);
                if (result.Succeeded)
                    return Ok("Password has been reset successfully!");
            }
           

            return BadRequest("Some properties are not valid");
        }
        [HttpPost]
        [Route("InviteFriend")]
        public async Task<IActionResult> InviteFriend(string UserEmail, string FriendEmail)
        {
            //string url = $"{http://localhost:3000/Registration}";
            var user = await _userManager.FindByEmailAsync(UserEmail);
            if(user==null)
            {
                return BadRequest(new { message = "There is no user with that Email address." });
            }

            await _emailService.SendEmailAsync(FriendEmail, "E-commerce", "<h1>Your friend "+user.FirstName+" "+ user.LastName+ " invite you to join us</h1>" +
                $"<p>To send  your friend coupon please <a href='http://localhost:3000/Registration'>Register</a></p>");
            return Ok("You invite your friend");

        }
        [HttpGet]
        [Route("SendCoupon")]
        public async Task<IActionResult> SendCoupon(string UserEmail)
        {
            var code = _couponService.GetCode();
            await _emailService.SendEmailAsync(UserEmail, "E-commerce", "<h1>Your friend accepted your invitation</h1>" +
                $"<p>Use the following discount code for your next purchase "+code + "</p>");
            return Ok("Code successfully sent");
        }
    }
}
