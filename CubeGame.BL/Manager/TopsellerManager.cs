using CubeGame.BL.DTO;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostpopular;
using CubeGame.DAL.Repo.topseller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class TopsellerManager : ITopsellerManager
    {
        ITopsellerRepo IR { get; }
        ICategoryRepo IC { get; }
        public TopsellerManager(ITopsellerRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<TopsellerDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<TopsellerDTO> TopsellerDTOs = new List<TopsellerDTO>();

            foreach (var i in ins)
            {
                TopsellerDTO dTO = new TopsellerDTO()
                {
                    TopsellerId = i.TopsellerId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName,
                    Picture = i.GetMainImage().ImageURL,


                };
                TopsellerDTOs.Add(dTO);
            }

            return TopsellerDTOs;
        }
    }
}
