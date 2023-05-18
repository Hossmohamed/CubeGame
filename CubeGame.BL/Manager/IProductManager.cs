using CubeGame.BL.DTO;
using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public interface IProductManager
    {
        public List<ProductDTO> GetAll();
        public ProductDTO getProductByID(int id);
        public void AddProduct(ProductDTO p);

        public void AddProductImages(int productId , Image i);

        public List<Image> GetProductImages(int productId);
        public void EditProduct(int id , ProductDTO p);

        public void DeleteProduct(int id);
    }
}
