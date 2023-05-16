using CubeGame.BL.Manager;
using CubeGame.DAL.Repo.cart;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        ICartRepo cartRepo;
        public CartController(ICartRepo _repo)
        {
            cartRepo = _repo;
        }

        [HttpGet]
        public IActionResult GetAllCartItems()
        {
            var CartItems = cartRepo.GetCartItems();
            return Ok(CartItems);
        }

        [HttpPost("AddToCart/{id}")]
        public IActionResult AddToCart(int id)
        {
            cartRepo.AddToCart(id);

            return Created("url" , id);
        }

        [HttpDelete("RemoveFromCart/{id}")]
        public IActionResult RemoveFromCart(string id)
        {
            var selectedProduct = cartRepo.GetCartItem(id);

            if (selectedProduct != null)
            {
                cartRepo.RemoveFromCart(id);
                return Ok(selectedProduct);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("ClearCart")]
        public IActionResult ClearCart()
        {
            cartRepo.ClearCart();
            return Ok();
        }
    }
}
