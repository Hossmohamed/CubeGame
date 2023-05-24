using CubeGame.BL.DTO;
using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public interface IRecentlyupdatedManager
    {
        public List<RecentlyupdatedDTO> GetAll();

    }
}
