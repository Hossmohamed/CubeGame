
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
using Stripe;


namespace CubeGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            StripeConfiguration.ApiKey = builder.Configuration["Stripe:SecretKey"];
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            builder.Services.AddRouting(options => options.LowercaseUrls = true);


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));

            // he know that we use Identity Role
            builder.Services.AddIdentity<ApplicationUser , IdentityRole>().AddEntityFrameworkStores<ApplicationDBContext>();
            builder.Services.AddDbContext<ApplicationDBContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("myConn"))
           );


            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.RequireHttpsMetadata = false;
                    o.SaveToken = false;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = builder.Configuration["JWT:Issuer"],
                        ValidAudience = builder.Configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
                    };
                });
            builder.Services.AddScoped<IAuthService, AuthService>();

            builder.Services.AddCors(option =>
            {
                option.AddPolicy(name: "AllowOrigin", builder =>
                {
                    builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                });
            });

            builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
            builder.Services.AddScoped<ICategoryManager, CategoryManager>();


            builder.Services.AddScoped<IProductRepo, ProductRepo>();
            builder.Services.AddScoped<IProductManager, ProductManager>();

            builder.Services.AddScoped<ICartRepo, CartRepo>();

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

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("AllowOrigin");

            app.UseAuthentication();
           
            app.UseAuthorization();

            app.UseStaticFiles();
            app.UseSession();
            app.MapControllers();
            app.Run();
        }
    }
}