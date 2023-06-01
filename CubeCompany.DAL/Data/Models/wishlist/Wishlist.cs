﻿using CubeGame.DAL.Data.Models.cart;
using CubeGame.Data.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Data.Models.wishlist
{
    public class Wishlist
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        [Required]
        public  string AccountID { get; set; }

        public virtual ApplicationUser? Account { get; set; }

        public virtual ICollection<wishlistItam> WishlistItams { get; set; } = new List<wishlistItam>();
        public bool IsActive { get; set; } = true;

    }
}
