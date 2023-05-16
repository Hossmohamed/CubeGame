using CubeGame.Data.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Data.Models.Cart
{
    public class CartItem
    {

        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }

        [DataType(DataType.Currency)]
        public  double Price { get; set; }

        //[DataType(DataType.Currency)]
        //public double DiscountedPrice { get; set; }

        //[DataType(DataType.Currency)]
        //public double PriceAfterDiscount { get; set; }    
        //public double Discount { get; set; }

       
    }
}