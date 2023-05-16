﻿using CubeGame.BL.DTO;
using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.product;
using CubeGame.Data.Context;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class ProductManager : IProductManager
    {
        IProductRepo IR { get; }
        ICategoryRepo IC {get;}

       
        public ProductManager(IProductRepo _IR , ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        
        }
        public void AddProductImages(int productId , ImageDTO pD)
        {
            Image I = new Image();      
            foreach (IFormFile formFile in pD.Picture)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    formFile.CopyTo(stream);
                    byte[] byteArray = stream.ToArray();
                    I.ImageData = (byteArray);
                    I.ProductId = productId;
                    I.Title = "image";
                }
                IR.AddImage(I);
;            }

        }
        public List<Image> GetProductImages(int productId)
        {
            return IR.GetImages(productId);
        }
        public void AddProduct(ProductDTO pD)
        {
           
            Product P = new Product();
            P.ProductName = pD.ProductName;
            P.Description = pD.Description;
            P.Price = pD.Price;
            P.Discount = pD.Discount;
            P.CategoryId = pD.CategoryId;
           
            //foreach (var byteArray in P.Images)
            //{
            //    MemoryStream stream = new MemoryStream(byteArray.ImageData);
            //    IFormFile formFile = new FormFile(stream, 0, byteArray.ImageData.Length, "file", "filename");
            //    pD.Picture.Add(formFile);
            //}
            //Image I = new Image();
            //foreach (IFormFile formFile in pD.Picture)
            //{
            //    using (MemoryStream stream = new MemoryStream())
            //    {
            //        formFile.CopyTo(stream);
            //        byte[] byteArray = stream.ToArray();
            //        I.ImageData = (byteArray);
            //        I.ProductId = pD.ProductId;
            //        I.Title = "image";
            //        _context.Images.Add(I);
            //        _context.SaveChanges();
            //    }               
            //}

            IR.AddProduct(P);
        }

        public void DeleteProduct(int id)
        {
            IR.DeleteProduct(id);
        }

        public void EditProduct(int id , ProductDTO dTO)
        {
            var P = IR.getProductByID(id);

            P.ProductName = dTO.ProductName;
            P.Description = dTO.Description;
            P.Price = dTO.Price;
            P.Discount = dTO.Discount;
            P.CategoryId = dTO.CategoryId;
            P.category.CategoryName = IC.GetById(P.CategoryId).CategoryName;

            IR.EditProduct(id, P);
        }

        public List<ProductDTO> GetAll()
        {

            var ins = IR.GetAll();
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId= i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,                
                };
                productDTOs.Add(dTO);
            }
       
            return productDTOs;
        }

        public ProductDTO getProductByID(int id)
        {
            var i = IR.getProductByID(id);
            ProductDTO insDTo = new ProductDTO();
            if (i != null)
            {
                insDTo.ProductId = i.ProductId;
                insDTo.ProductName = i.ProductName;
                insDTo.Description = i.Description;
                insDTo.Price = i.Price;
                insDTo.Discount = i.Discount;
                insDTo.CategoryId = i.CategoryId;
                //insDTo.CategoryName = IC.GetById(insDTo.CategoryId).CategoryName;            
            }

            return insDTo;
        }
    }
}
