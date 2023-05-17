using CubeGame.BL.DTO;
using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.operatingSYstem;
using CubeGame.DAL.Repo.product;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public class OsManager : IOsManager
    {
        IOsRepo IR { get; }

        public OsManager(IOsRepo _IR)
        {
            IR = _IR;
        }
        public void AddOs(OsDTO p)
        {
            OS o = new OS();
            o.platform = p.platform;
            o.ProductId = p.ProductId;

            IR.Add(o);
        }

        public void DeleteOs(int id)
        {
            IR.Delete(id);
        }

        public void EditOs(int id, OsDTO p)
        {
            var P = IR.GetById(id);

            P.platform = p.platform;
            P.ProductId = p.ProductId;

            IR.Update(id, P);
        }

        public List<OsDTO> GetAll()
        {
            var ins = IR.GetAll();
            List<OsDTO> OsDTOs = new List<OsDTO>();
            foreach (var i in ins)
            {
                OsDTO dTO = new OsDTO()
                {
                    platform = i.platform,
                    ProductId = i.ProductId

                };
                OsDTOs.Add(dTO);
            }

            return OsDTOs;
        }

        public OsDTO getOsByID(int id)
        {
            var i = IR.GetById(id);
            OsDTO insDTo = new OsDTO();
            if (i != null)
            {
                insDTo.platform = i.platform;
                insDTo.ProductId = i.ProductId;
            }

            return insDTo;
        }
    }
}
