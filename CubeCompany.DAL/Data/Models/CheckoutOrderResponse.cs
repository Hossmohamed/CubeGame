using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Data.Models
{
    public class CheckoutOrderResponse
    {
        [Key]
        public int Id { get; set; }
        public string? SessionId { get; set; }
        public string? PubKey { get; set; }
    }
}