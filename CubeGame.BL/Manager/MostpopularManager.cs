using CubeGame.BL.DTO;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostplayed;
using CubeGame.DAL.Repo.mostpopular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class MostpopularManager : IMostpopularManager
    {
        IMostpopularRepo IR { get; }
        ICategoryRepo IC { get; }
        public MostpopularManager(IMostpopularRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<MostpopularDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<MostpopularDTO> MostpopularDTOs = new List<MostpopularDTO>();

            foreach (var i in ins)
            {
                MostpopularDTO dTO = new MostpopularDTO()
                {
                    MostpopularId = i.MostpopularId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName,
                    Picture = i.GetMainImage().ImageURL,

                };
                MostpopularDTOs.Add(dTO);
            }

            return MostpopularDTOs;
        }
    }
}
