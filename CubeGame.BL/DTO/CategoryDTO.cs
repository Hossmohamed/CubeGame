using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.DTO
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

       // public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
