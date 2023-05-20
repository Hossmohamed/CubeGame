using CubeGame.DAL.Repo.Services;
using CubeGame.Data.Models.Account;
using CubeGame.DAL.Repo.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return Ok(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            //SetRefreshTokenInCookie(result.RefreshToken, result.RefreshTokenExpiration);
            SetRefreshTokenInCookie(result.Token);

            return Ok("Ok");
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
                //SetRefreshTokenInCookie(result.RefreshToken, result.RefreshTokenExpiration);
                SetRefreshTokenInCookie(result.Token);
            return Ok(result);
        }

        [HttpGet("refreshToken")]
        public async Task<IActionResult> RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];

            var result = await _authService.RefreshTokenAsync(refreshToken);

            if (!result.IsAuthenticated)
                return BadRequest(result);

            //SetRefreshTokenInCookie(result.RefreshToken, result.RefreshTokenExpiration);
            SetRefreshTokenInCookie(result.Token);

            return Ok(result);
        }

        //private void SetRefreshTokenInCookie(string refreshToken, DateTime expires)
        //{
        //    var cookieOptions = new CookieOptions
        //    {
        //        HttpOnly = true,
        //        Expires = expires.ToLocalTime(),
        //        Secure = true,
        //        IsEssential = true,
        //        SameSite = SameSiteMode.None
        //    };

        //    Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        //}

        private void SetRefreshTokenInCookie(string Token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                //Expires = expires.ToLocalTime(),
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.None
            };

            Response.Cookies.Append("refreshToken", Token, cookieOptions);
        }
    }
}
