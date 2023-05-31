﻿using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.product
{
    public interface IProductRepo
    {
        public List<Product> GetAll();
        public Product getProductByID(int id);
        public void AddProduct(Product p);

        public void EditProduct(int id, Product P);

        public void DeleteProduct(int id);

        public List<Image> GetImages(int id);

        public void AddImage(Image I);
    }
}
