using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.onsale
{
    public interface IOnsaleRepo
    {
        public List<Onsale> GetAll();

    }
}
