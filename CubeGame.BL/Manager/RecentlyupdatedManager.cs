using CubeGame.BL.DTO;
using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostplayed;
using CubeGame.DAL.Repo.recentlyupdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class RecentlyupdatedManager : IRecentlyupdatedManager
    {
        IRecentlyupdatedRepo IR { get; }
        ICategoryRepo IC { get; }
        public RecentlyupdatedManager(IRecentlyupdatedRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<RecentlyupdatedDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<RecentlyupdatedDTO> RecentlyupdatedDTOs = new List<RecentlyupdatedDTO>();

            foreach (var i in ins)
            {
                RecentlyupdatedDTO dTO = new RecentlyupdatedDTO()
                {
                    RecentlyupdatedId = i.RecentlyupdatedId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName

                };
                RecentlyupdatedDTOs.Add(dTO);
            }

            return RecentlyupdatedDTOs;
        }

    }
}