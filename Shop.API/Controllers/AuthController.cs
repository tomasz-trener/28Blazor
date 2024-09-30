using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.API.Services;
using Shop.Shared.Auth;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Test")]
        [Authorize]
        public async Task<IActionResult> Test()
        {
            return Ok("Test");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto userLogin)
        {
            var response = await _authService.LoginAsync(userLogin.Email, userLogin.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto userRegister)
        {
            var user = new User
            {
                Email = userRegister.Email,
                Username = userRegister.UserName,
            };

            var response = await _authService.RegisterAsync(user, userRegister.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}
