using CubeGame.BL.DTO;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.freegame;
using CubeGame.DAL.Repo.mostpopular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class FreegameManager : IFreegameManager
    {
        IFreegameRepo IR { get; }
        ICategoryRepo IC { get; }
        public FreegameManager(IFreegameRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<FreegameDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<FreegameDTO> FreegameDTOs = new List<FreegameDTO>();

            foreach (var i in ins)
            {
                FreegameDTO dTO = new FreegameDTO()
                {
                    FreegameId = i.FreegameId,
                    ProductName = i.ProductName,
                    ReleaseDate = i.ReleaseDate,
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName

                };
                FreegameDTOs.Add(dTO);
            }

            return FreegameDTOs;
        }
    }
}
