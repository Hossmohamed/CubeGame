using CubeGame.BL.DTO;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostplayed;
using CubeGame.DAL.Repo.newrelease;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class NewreleaseManager : INewreleaseManager
    {
        INewreleaseRepo IR { get; }
        ICategoryRepo IC { get; }
        public NewreleaseManager(INewreleaseRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<NewreleaseDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<NewreleaseDTO> NewreleaseDTOs = new List<NewreleaseDTO>();

            foreach (var i in ins)
            {
                NewreleaseDTO dTO = new NewreleaseDTO()
                {
                    NewreleaseId = i.NewreleaseId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName

                };
                NewreleaseDTOs.Add(dTO);
            }

            return NewreleaseDTOs;
        }
    }
}