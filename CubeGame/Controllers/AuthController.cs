using CubeGame.DAL.Repo.Services;
using CubeGame.Data.Models.Account;
using CubeGame.DAL.Repo.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
=======
>>>>>>> parent of 75946e2 (SomeEdits&Dashboard)

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AuthController(IAuthService authService, SignInManager<ApplicationUser> signInManager)
        {
            _authService = authService;
            _signInManager = signInManager;

        }
        //[HttpGet("ExternalLogin")]
        //public IActionResult ExternalLogin(string provider)
        //{
        //    // Request a redirect to the external login provider.
        //    var redirectUrl = Url.Action("ExternalLoginCallback", "Auth");
        //    var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        //    return Challenge(properties, provider);
        //}

        //[HttpGet("ExternalLoginCallback")]

        //public async Task<IActionResult> ExternalLoginCallback()
        //{
        //    // Handle the callback from the external login provider.
        //    var info = await _signInManager.GetExternalLoginInfoAsync();
        //    if (info == null)
        //    {
        //        // Handle the case where the external login info is not available.
        //        return BadRequest();
        //    }

        //    // Sign in the user with the external login provider.
        //    var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
        //    if (result.Succeeded)
        //    {
        //        // User is successfully signed in.
        //        // Redirect or return a response as needed.
        //        return Ok();
        //    }
        //    else
        //    {
        //        // Handle the case where the external login failed or the user is not registered.
        //        // Redirect or return a response as needed.
        //        return BadRequest();
        //    }
        //}

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return Ok(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            SetRefreshTokenInCookie(result.RefreshToken, result.RefreshTokenExpiration);
            //SetRefreshTokenInCookie(result.Token);

            return Ok(result);
        }
        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync([FromBody] TokenRequestModel model)
        {
            if (!ModelState.IsValid)
                return Ok(ModelState);

            var result = await _authService.GetTokenAsync(model);

            if (!result.IsAuthenticated)
                return Ok(result.Message);

            if (!string.IsNullOrEmpty(result.RefreshToken))
                SetRefreshTokenInCookie(result.RefreshToken, result.RefreshTokenExpiration);
            //SetRefreshTokenInCookie(result.Token);
            return Ok(result);
        }

        [HttpGet("refreshToken")]
        public async Task<IActionResult> RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];

            var result = await _authService.RefreshTokenAsync(refreshToken);

            if (!result.IsAuthenticated)
                return BadRequest(result);

            SetRefreshTokenInCookie(result.RefreshToken, result.RefreshTokenExpiration);
            //SetRefreshTokenInCookie(result.Token);

            return Ok(result);
        }

        private void SetRefreshTokenInCookie(string refreshToken, DateTime expires)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = expires.ToLocalTime(),
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.None
            };

            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }

        //private void SetRefreshTokenInCookie(string Token)
        //{
        //    var cookieOptions = new CookieOptions
        //    {
        //        HttpOnly = true,
        //        //Expires = expires.ToLocalTime(),
        //        Secure = true,
        //        IsEssential = true,
        //        SameSite = SameSiteMode.None
        //    };

        //    Response.Cookies.Append("refreshToken", Token, cookieOptions);
        //}
    }
}
