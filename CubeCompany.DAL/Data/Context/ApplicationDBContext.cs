using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Data.Models.Cart;
using CubeGame.Data.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CubeGame.Data.Context
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder
                .Entity<Product>().HasMany(P => P.Images).WithOne(A => A.Product)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Cart>().HasQueryFilter(C => C.IsActive == true);

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Wishlist> wishlists { get; set; }
<<<<<<< HEAD
        public DbSet<Mostplayed> Mostplayeds { get; set; }
        public DbSet<Mostpopular> Mostpopulars { get; set; }
        public DbSet<Toprated> Toprateds { get; set; }
        public DbSet<Newrelease> Newreleases { get; set; }
        public DbSet<Freegame> Freegames { get; set; }
        public DbSet<Comingsoon> Comingsoons { get; set; }
        public DbSet<Topseller> Topsellers { get; set; }
        public DbSet<Recentlyupdated> Recentlyupdateds { get; set; }
        public DbSet<Onsale> Onsales { get; set; }



=======
      
>>>>>>> 12be01178db1b55c3f08f72f0a040921208ebfc1

    }
}
