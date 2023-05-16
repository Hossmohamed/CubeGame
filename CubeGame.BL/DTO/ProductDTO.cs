using CubeGame.DAL.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public  string ProductName { get; set; }
        public  string Description { get; set; }
        public  double Price { get; set; }
        public double Discount { get; set; }
        public int CategoryId { get; set; }

        //public string CategoryName { get; set; }
        //public virtual ICollection<Image> Picture { get; set; } = new List<Image>();
    }
}
