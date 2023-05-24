using CubeGame.DAL.Repo.cart;
using CubeGame.DAL.Repo.wishlist;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WishlistController : ControllerBase
    {
        private readonly IwishlistRepo wishlistRepo;

        public WishlistController(IwishlistRepo _wishlistRepo)
        {
           wishlistRepo = _wishlistRepo;
        }
        [HttpGet]
        public IActionResult Get() 
        {
        return Ok(wishlistRepo.GetwishlisttItems());
        
        }
        [HttpPost("{Id}")]
        public IActionResult AddTowishlist(int Id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
           
            wishlistRepo.AddToWishlist(Id);

            return Created("url", Id);
        }

    }
}
