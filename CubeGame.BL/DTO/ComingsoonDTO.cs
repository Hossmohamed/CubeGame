﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.DTO
{
    public class ComingsoonDTO
    {
        public int ComingsoonId { get; set; }

        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }
        public string? Picture { get; set; }

    }
}
