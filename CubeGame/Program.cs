
using CubeGame.Data.Context;
using CubeGame.Data.Helper;
using CubeGame.Data.Models.Account;
using CubeGame.DAL.Repo.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;
using CubeGame.BL.Manager;
using CubeGame.DAL.Repo.product;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.cart;
using CubeGame.DAL.Repo.wishlist;
using CubeGame.DAL.Repo.mostplayed;
using CubeGame.DAL.Repo.mostpopular;
using CubeGame.DAL.Repo.toprated;
using CubeGame.DAL.Repo.newrelease;
using CubeGame.DAL.Repo.freegame;
using CubeGame.DAL.Repo.comingsoon;
using CubeGame.DAL.Repo.topseller;
using CubeGame.DAL.Repo.recentlyupdated;
using CubeGame.DAL.Repo.onsale;

namespace CubeGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
           

            builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));

            builder.Services.AddScoped<IAuthService, AuthService>();

            // he know that we use Identity Role
            builder.Services.AddIdentity<ApplicationUser , IdentityRole>().AddEntityFrameworkStores<ApplicationDBContext>();
            builder.Services.AddDbContext<ApplicationDBContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("myConn"))
           );


            //builder.Services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //    .AddJwtBearer(o =>
            //    {
            //        o.RequireHttpsMetadata = false;
            //        o.SaveToken = false;
            //        o.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateIssuerSigningKey = true,
            //            ValidateIssuer = true,
            //            ValidateAudience = true,
            //            ValidateLifetime = true,
            //            ValidIssuer = builder.Configuration["JWT:Issuer"],
            //            ValidAudience = builder.Configuration["JWT:Audience"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
            //        };
            //    });

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    ValidAudience = builder.Configuration["JWT:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
                };
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(option =>
            {
                option.AddPolicy(name: "AllowOrigin", builder =>
                {
                    builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                });
            });

            builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
            builder.Services.AddScoped<ICategoryManager, CategoryManager>();

            builder.Services.AddScoped<IProductRepo, ProductRepo>();
            builder.Services.AddScoped<IProductManager, ProductManager>();
            //addCart
            builder.Services.AddScoped<ICartRepo, CartRepo>();
            builder.Services.AddScoped<ICartManager, CartManager>();
            //addwishList
            builder.Services.AddScoped<IwishlistRepo,WishListRepo>();
            //addmostplayed
            builder.Services.AddScoped<IMostplayedRepo, MostplayedRepo>();
            builder.Services.AddScoped<IMostplayedManager, MostplayedManager>();
            //addmostpopular
            builder.Services.AddScoped<IMostpopularRepo, MostpopularRepo>();
            builder.Services.AddScoped<IMostpopularManager, MostpopularManager>();
            //addtoprated
            builder.Services.AddScoped<ITopratedRepo, TopratedRepo>();
            builder.Services.AddScoped<ITopratedManager, TopratedManager>();
            //addnewrelease
            builder.Services.AddScoped<INewreleaseRepo, NewreleaseRepo>();
            builder.Services.AddScoped<INewreleaseManager, NewreleaseManager>();
            //addfreegame
            builder.Services.AddScoped<IFreegameRepo, FreegameRepo>();
            builder.Services.AddScoped<IFreegameManager, FreegameManager>();
            //addcomingsoon
            builder.Services.AddScoped<IComingsoonRepo, ComingsoonRepo>();
            builder.Services.AddScoped<IComingsoonManager, ComingsoonManager>();
            //addtopseller
            builder.Services.AddScoped<ITopsellerRepo, TopsellerRepo>();
            builder.Services.AddScoped<ITopsellerManager, TopsellerManager>();
            //addrecentlyupdated
            builder.Services.AddScoped<IRecentlyupdatedRepo, RecentlyupdatedRepo>();
            builder.Services.AddScoped<IRecentlyupdatedManager, RecentlyupdatedManager>();
            //addonsale
            builder.Services.AddScoped<IOnsaleRepo, OnsaleRepo>();
            builder.Services.AddScoped<IOnsaleManager, OnsaleManager>();

            //for session
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
               
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseRouting();
            app.UseAuthentication();
           
            app.UseAuthorization();

            app.UseHttpsRedirection();


            app.UseCors("AllowOrigin");


            app.UseStaticFiles();
           
            app.MapControllers();
            app.Run();
        }
    }
}