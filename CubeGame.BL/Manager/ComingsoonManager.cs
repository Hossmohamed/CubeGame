using CubeGame.BL.DTO;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.comingsoon;
using CubeGame.DAL.Repo.mostplayed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class ComingsoonManager : IComingsoonManager
    {
        IComingsoonRepo IR { get; }
        ICategoryRepo IC { get; }
        public ComingsoonManager(IComingsoonRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<ComingsoonDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<ComingsoonDTO> ComingsoonDTOs = new List<ComingsoonDTO>();

            foreach (var i in ins)
            {
                ComingsoonDTO dTO = new ComingsoonDTO()
                {
                    ComingsoonId = i.ComingsoonId,
                    ProductName = i.ProductName,
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName

                };
                ComingsoonDTOs.Add(dTO);
            }

            return ComingsoonDTOs;
        }
    }
}