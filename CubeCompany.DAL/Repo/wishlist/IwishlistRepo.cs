using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Data.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.wishlist
{
    public interface IwishlistRepo
    {
        public List<Wishlist> GetwishlisttItems();
        public void AddToWishlist(int id );
    }
}
