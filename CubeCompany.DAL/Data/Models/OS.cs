using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Data.Models
{
    public class OS
    {
        [Key]
        public int id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string platform { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [ForeignKey("Product")]

        public int ProductId { get; set; }

        public Product product { get; set; }
    }
}
