using CubeGame.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.BL.Manager
{
    public interface IOsManager
    {
        public List<OsDTO> GetAll();
        public OsDTO getOsByID(int id);
        public void AddOs(OsDTO p);
        public void EditOs(int id, OsDTO p);
        public void DeleteOs(int id);
    }
}
