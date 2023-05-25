using CubeGame.BL.DTO;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.onsale;
using CubeGame.DAL.Repo.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class OnsaleManager : IOnsaleManager
    {
        IOnsaleRepo IR { get; }
        ICategoryRepo IC { get; }

        public OnsaleManager(IOnsaleRepo _IR, ICategoryRepo _IC)
        {
            IR = _IR;
            IC = _IC;
        }
        public List<OnsaleDTO> GetAll()
        {

            var ins = IR.GetAll();

            List<OnsaleDTO> OnsaleDTOs = new List<OnsaleDTO>();

            foreach (var i in ins)
            {
                OnsaleDTO dTO = new OnsaleDTO()
                {
                    OnsaleId = i.OnsaleId,
                    ProductName = i.ProductName,
                    Price = i.Price,
                    Discount = i.Discount,
                    CategoryId = i.CategoryId,
                    Picture = i.GetMainImage().ImageURL,
                    CategoryName = IC.GetById(i.CategoryId).CategoryName
                };
                OnsaleDTOs.Add(dTO);
            }

            return OnsaleDTOs;

        }
    }
}