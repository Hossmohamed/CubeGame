using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.DTO
{
    public class FreegameDTO
    {
        public int FreegameId { get; set; }

        public string ProductName { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }
        public string? Picture { get; set; }

    }
}
