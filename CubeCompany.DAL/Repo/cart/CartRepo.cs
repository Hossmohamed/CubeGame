using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Data.Models.Cart;
using CubeGame.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.cart
{
    public class CartRepo : ICartRepo
    {
        private readonly ApplicationDBContext context;
        private readonly IHttpContextAccessor HttpContextAccessor;
        public CartRepo(ApplicationDBContext _context, IHttpContextAccessor _HttpContextAccessor)
        {
            context = _context;
            HttpContextAccessor = _HttpContextAccessor;
        }

        public void AddToCart(int id)
        {
            // Retrieve the product from the database.           
            string ShoppingCartId = GetCartId(new Cart());
            var price = context.Products.SingleOrDefault(p => p.ProductId == id).Price;
            var cartItem = context.cartItems.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.ProductId == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                cartItem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    ProductId = id,
                    CartId = ShoppingCartId,
                    Price = price,
                    Product = context.Products.SingleOrDefault(
                   p => p.ProductId == id),
                    Quantity = 1
                };

                context.cartItems.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,                  
                // then add one to the quantity.                 
                cartItem.Quantity = 1;
            }
            context.SaveChanges();
        }

        public void ClearCart()
        {
            string ShoppingCartId = GetCartId(new Cart());

            var cartItems = context.cartItems.Where(c => c.CartId == ShoppingCartId);
            context.cartItems.RemoveRange(cartItems);
            context.SaveChanges();
        }

        public string GetCartId(Cart cart)
        {
            ISession session = HttpContextAccessor.HttpContext.Session;
            if (session.GetString(cart.CartSessionKey) == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContextAccessor.HttpContext.User.Identity.Name))
                {
                    session.SetString(cart.CartSessionKey, HttpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    session.SetString(cart.CartSessionKey, tempCartId.ToString());
                }
            }
            return session.GetString(cart.CartSessionKey);
        }

        public CartItem GetCartItem(string id)
        {
            return context.cartItems.SingleOrDefault(c => c.ItemId == id);
        }

        public List<CartItem> GetCartItems()
        {
            string ShoppingCartId = GetCartId(new Cart());

            return context.cartItems.Where(c => c.CartId == ShoppingCartId).Include(c => c.Product).ToList();
        }

        public double GetCartTotal()
        {
            string ShoppingCartId = GetCartId(new Cart());
            return context.cartItems
                .Where(c => c.CartId == ShoppingCartId)
                .Select(c => c.Product.PriceAfterDiscount() * c.Quantity)
                .Sum();
        }

        public void RemoveFromCart(string id)
        {
            string ShoppingCartId = GetCartId(new Cart());
            var cartItem = context.cartItems.SingleOrDefault(c => c.CartId == ShoppingCartId && c.ItemId == id);

            if (cartItem != null)
            {
                context.cartItems.Remove(cartItem);
            }
            context.SaveChanges();
        }
    }
}
