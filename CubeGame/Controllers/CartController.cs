using CubeGame.BL.Manager;
using CubeGame.DAL.Repo.cart;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICartRepo cartRepo;
        private readonly ICartManager CM;
        public CartController(ICartRepo _repo , IHttpContextAccessor httpContextAccessor , ICartManager _CM)
        {
            cartRepo = _repo;
            _httpContextAccessor = httpContextAccessor;
            CM = _CM;
        }

        [HttpGet]
        public IActionResult GetAllCartItems()
        {
            var refreshToken = Request.Cookies["refreshToken"];

            var CartItems = CM.GetAll(refreshToken);

            return Ok(CartItems);
        }
      
        [HttpPost("AddToCart/{id}")]   
        public IActionResult AddToCart(int id)
        {
            //var claimsPrincipal = User;
            //var userIdClaim = claimsPrincipal.FindFirst("uid");

            //var userId = userIdClaim?.Value;


            //var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync("access_token");

            //// Use the claims as needed
            //var name = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            //var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            //var customClaim = claims.FirstOrDefault(c => c.Type == "uid")?.Value;


            //var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync("refreshToken");
            //var currentUser = User.Identity.Name;
            // cartRepo.AddToCart(id , accessToken);


            //var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            //var name = claimsPrincipal.FindFirst(ClaimTypes.Name)?.Value;
            //var email = claimsPrincipal.FindFirst(ClaimTypes.Email)?.Value;
            //var customClaim = claimsPrincipal.FindFirst("uid")?.Value;

            var refreshToken = Request.Cookies["refreshToken"];

              cartRepo.AddToCart(id , refreshToken);
            //var result = string.Empty;
            //if (_httpContextAccessor.HttpContext != null)
            //{
            //    result = _httpContextAccessor.HttpContext.User.FindFirstValue("uid");
            //}

            //return Created("url", User.Identity.IsAuthenticated);

            return Created("url", "Ok");
        }

        [HttpDelete("RemoveFromCart/{id}")]
        public IActionResult RemoveFromCart(int id)
        {
            var refreshToken = Request.Cookies["refreshToken"];
     
             cartRepo.RemoveFromCart(id , refreshToken);

             return Ok("ok");          
           
        }

        [HttpDelete("ClearCart")]
        public IActionResult ClearCart()
        {
            var refreshToken = Request.Cookies["refreshToken"];

            cartRepo.ClearCart(refreshToken);

            return Ok();
        }
    }
}
