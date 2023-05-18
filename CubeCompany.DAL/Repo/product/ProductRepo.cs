using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.product
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public ProductRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }
        public void AddProduct(Product p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public void EditProduct(int id, Product pD)
        {
            var P = _context.Products.FirstOrDefault(p => p.ProductId == id);
            P.ProductName = pD.ProductName;
            P.Description = pD.Description;
            P.Price = pD.Price;
            P.Discount = pD.Discount;
            P.DeveloperName = pD.DeveloperName;
            P.RAM = pD.RAM;
            P.Processor = pD.Processor;
            P.ReleaseDate = pD.ReleaseDate;
            P.CategoryId = pD.CategoryId;
            _context.Update(P);
            _context.SaveChanges();
        }
        public List<Image> GetImages(int Productid)
        {
            return _context.Images.Where(x => x.ProductId == Productid).ToList();
        }

        public void AddImage(Image I)
        {
            _context.Images.Add(I);
            _context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return _context.Products.Include(i => i.Images).Include(c => c.category).ToList();
        }

        public Product getProductByID(int id)
        {
            return _context.Products.Include(i => i.Images).Include(c => c.category).SingleOrDefault(g => g.ProductId == id);
        }
    }
}
