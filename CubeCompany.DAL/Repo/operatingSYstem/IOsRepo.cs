using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.operatingSYstem
{
    public interface IOsRepo
    {
        IEnumerable<OS> GetAll();
        OS GetById(int id);
        List<OS> GetProducts(int id);
        void Add(OS c);
        void Update(int id, OS c);
        void Delete(int id);
    }
}
