using CubeGame.BL.DTO;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostplayed;
using CubeGame.DAL.Repo.toprated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class TopratedManager : ITopratedManager
    {
        ITopratedRepo IR { get; }
        ICategoryRepo IC { get; }
        public TopratedManager(ITopratedRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }

        public List<TopratedDTO> GetAll()
        {
            var ins = IR.GetAll();

            List<TopratedDTO> TopratedDTOs = new List<TopratedDTO>();

            foreach (var i in ins)
            {
                TopratedDTO dTO = new TopratedDTO()
                {
                    TopratedId = i.TopratedId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName

                };
                TopratedDTOs.Add(dTO);
            }

            return TopratedDTOs;
        }
    }
}
