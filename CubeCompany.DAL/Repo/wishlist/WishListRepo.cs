using CubeGame.DAL.Data.Models;
using CubeGame.Data.Context;
using CubeGame.Data.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.wishlist
{
    public class WishListRepo:IwishlistRepo
    {
        private readonly ApplicationDBContext context;
        private readonly IHttpContextAccessor httpContextAccessor;
      

        public WishListRepo(ApplicationDBContext _context, IHttpContextAccessor _httpContextAccessor)
        {
            context = _context;
            httpContextAccessor = _httpContextAccessor;
        
        }
        //public void AddToWishlist(int id, string token)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var validationParameters = new TokenValidationParameters
        //    {
        //        //ValidateIssuerSigningKey = true,
        //        //IssuerSigningKey = jwt.Key, // Replace with your security key

        //        ValidateIssuer = true,
        //        ValidIssuer = jwt.Issuer, // Replace with your issuer

        //        ValidateAudience = true,
        //        ValidAudience = jwt.Audience, // Replace with your audience

        //        // Additional validation if needed
        //        // ...

        //    };

        //    try
        //    {
        //        // Validate the token
        //        SecurityToken validatedToken;
        //        var principal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);

        //        // Get the user ID from the validated token
        //        var userIdClaim = principal.FindFirst(ClaimTypes.NameIdentifier);
        //        var userId = userIdClaim.Value;

        //        var wishlist = context.wishlists.FirstOrDefault(w => w.ProductID == id && w.AccountID == userId);
        //        if (wishlist == null && userId != null)
        //        {
        //            var wishlistItem = new Wishlist
        //            {
        //                AccountID = userId,
        //                ProductID = id
        //            };

        //            context.wishlists.Add(wishlistItem);
        //            context.SaveChanges();
        //        }
        //    }
        //    catch (SecurityTokenValidationException ex)
        //    {
        //        // Handle token validation exception
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle other exceptions
        //    }
        //}



        public List<Wishlist> GetwishlisttItems()
        {

            var userIdClaim = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

            var userId = userIdClaim.Value;
            var wishlistItems = context.wishlists
               .Include(w => w.Product)
               .ThenInclude(p => p.Images)
               .Where(w => w.AccountID.ToString() == userId)
               .ToList();
            return wishlistItems;
        }
        
public void AddToWishlist(int id)
{
    var userIdClaim = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

    var userId = userIdClaim.Value;


    var wishlist = context.wishlists.FirstOrDefault(w => w.ProductID == id && w.AccountID == userId);
    if (wishlist == null && userId != null)
    {
        var wishlistItem = new Wishlist
        {
            AccountID = userId,
            ProductID = id
        };

        context.wishlists.Add(wishlistItem);
        context.SaveChanges();
    }



}
    }
}
