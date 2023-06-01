using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Data.Models
{
    public class Newrelease
    {
        [Key]
        public int NewreleaseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public double Price { get; set; }

        [ForeignKey("Category")]

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();

        public Image? GetMainImage()
        {
            if (Images.Count == 0) return null;
            return Images.FirstOrDefault();
        }
    }
}

