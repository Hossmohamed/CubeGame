using CubeGame.Data.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Data.Models
{
    public class Wishlist
    {
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        [Required]
        public required string AccountID { get; set; }

        [ForeignKey("Product")]
        [Required]
        public required int ProductID { get; set; }
        public virtual ApplicationUser? Account { get; set; }
        public virtual Product? Product { get; set; }
    }
}
