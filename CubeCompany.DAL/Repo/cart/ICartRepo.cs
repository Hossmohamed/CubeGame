using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Data.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.cart
{
    public interface ICartRepo
    {
        public string GetCartId(Cart cart);
        public void AddToCart(int id);
        public List<CartItem> GetCartItems();
        public void ClearCart();
        public void RemoveFromCart(string id);
        public double GetCartTotal();
        public CartItem GetCartItem(string id);
    }
}
