
using CubeGame.BL.DTO;
using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.product;
using CubeGame.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OS = CubeGame.BL.DTO.OS;

namespace CubeGame.BL.Manager
{
    public class ProductManager : IProductManager
    {
        IProductRepo IR { get; }
        ICategoryRepo IC {get;}
   
        public ProductManager(IProductRepo _IR , ICategoryRepo _IC )
        {
            IR = _IR;
            IC = _IC; 
        }


        public List<Image> GetProductImages(int productId)
        {
            return IR.GetImages(productId);
        }

        public void AddProductImages(int productId, Image I)
            {
                  I.ProductId = productId;
                  I.Title = "image";
                  IR.AddImage(I);             
            }

            public void AddProduct(ProductDTO pD)
              {
           
            Product P = new Product();
            P.ProductName = pD.ProductName;
            P.Description = pD.Description;
            P.Price = pD.Price;
            P.Discount = pD.Discount;
            P.CategoryId = pD.CategoryId;
            P.DeveloperName = pD.DeveloperName;
            P.RAM = pD.RAM;
            P.Processor = pD.Processor;
            P.ReleaseDate = pD.ReleaseDate;
           
            OS enumValue = (OS)Enum.Parse(typeof(OS), pD.platform);

            P.platform = (DAL.Data.Models.OS)enumValue;


            
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
            P.DeveloperName = dTO.DeveloperName;
            P.RAM = dTO.RAM;
            P.Processor = dTO.Processor;
            P.ReleaseDate = dTO.ReleaseDate;
           // P.platform = dTO.platform;
            //P.category.CategoryName = IC.GetById(P.CategoryId).CategoryName;

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
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
            };
                productDTOs.Add(dTO);
            }

            return productDTOs;
         
        }

        public List<ProductDTO> GetAllComingSoon()
        {

            var ins = IR.GetAllComingSoon();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllGameOnSale()
        {

            var ins = IR.GetAllGameOnSale();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllMostPopular()
        {

            var ins = IR.GetAllMostPopular();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllMostPlayed()
        {

            var ins = IR.GetAllMostPlayed();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllRecentlyUpdated()
        {

            var ins = IR.GetAllRecentlyUpdated();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllNewRelease()
        {

            var ins = IR.GetAllNewRelease();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllTopRated()
        {

            var ins = IR.GetAllTopRated();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllTopSeller()
        {

            var ins = IR.GetAllTopSeller();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                productDTOs.Add(dTO);
            }

            return productDTOs;

        }
        public List<ProductDTO> GetAllFreeGames()
        {

            var ins = IR.GetAllFreeGames();

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var i in ins)
            {
                ProductDTO dTO = new ProductDTO()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Description = i.Description,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    DeveloperName = i.DeveloperName,
                    RAM = i.RAM,
                    Processor = i.Processor,
                    ReleaseDate = i.ReleaseDate,
                    platform = i.platform.ToString(),
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
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
                insDTo.DeveloperName = i.DeveloperName;
                insDTo.RAM = i.RAM;
                insDTo.Processor = i.Processor;
                insDTo.ReleaseDate = i.ReleaseDate;
                insDTo.platform = i.platform.ToString();
                insDTo.Picture = i.GetMainImage().ImageURL;
                insDTo.CategoryName = IC.GetById(i.CategoryId).CategoryName;
            }

            return insDTo;
        }
    }
}
