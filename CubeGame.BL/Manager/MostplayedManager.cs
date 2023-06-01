using CubeGame.BL.DTO;
using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostplayed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class MostplayedManager : IMostplayedManager
    {
        IMostplayedRepo IR { get; }
        ICategoryRepo IC { get; }
        public MostplayedManager(IMostplayedRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<MostplayedDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<MostplayedDTO> MostplayedDTOs = new List<MostplayedDTO>();

            foreach (var i in ins)
            {
                MostplayedDTO dTO = new MostplayedDTO()
                {
                    MostplayedId = i.MostplayedId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName,
                    Picture = i.GetMainImage().ImageURL,

                };
                MostplayedDTOs.Add(dTO);
            }

            return MostplayedDTOs;
        }
        //public List<MostplayedDTO> GetAll()
        //{



        //}
    }
}
