using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.DTO
{
    public class OsDTO
    {
        public int id { get; set; }

        public string platform { get; set; }
       public int ProductId { get; set; }

    }
}
