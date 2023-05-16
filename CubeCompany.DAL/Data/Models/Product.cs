using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public  string ProductName { get; set; }

        [Required]
        public  string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public  double Price { get; set; }


        [Range(0, 100)]
        [RegularExpression("^(([1-9]*)|(([1-9]*)\\.([0-9]*)))$")]
        [DefaultValue(0.00)]
        public double Discount { get; set; }


        [RegularExpression("^(([1-9*)|(([1-9]*)\\.([0-9]*)))$")]
        [DefaultValue(0.00)]
        public double ? Rate { get; set; }
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();

        [Required]
        [ForeignKey("Category")]

        public  int CategoryId { get; set; }

        public Category category { get; set; }

        public Image? GetMainImage()
        {
            if (Images.Count == 0) return null;
            return Images.FirstOrDefault();
        }
        public double PriceAfterDiscount() => Price * (1 - Discount / 100);
        public double DiscountedAmount() => Price * (Discount / 100);
    }
}
