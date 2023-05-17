using CubeGame.DAL.Data.Models;
using CubeGame.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.operatingSYstem
{
    public class OsRepo : IOsRepo
    {
        private readonly ApplicationDBContext _context;

        public OsRepo(ApplicationDBContext context)
        {
            _context = context;
        }
        public void Add(OS c)
        {
            _context.Add(c);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = _context.oS.FirstOrDefault(g => g.id == id);
            _context.Remove(c);
            _context.SaveChanges();
        }

        public IEnumerable<OS> GetAll()
        {
            return _context.oS.ToList();
        }

        public OS GetById(int id)
        {
            return _context.oS.SingleOrDefault(g => g.id == id);
        }

        public void Update(int id, OS c)
        {
            var old = _context.oS.FirstOrDefault(g => g.id == id);
            old.platform = c.platform;
            old.ProductId = c.ProductId;
            _context.Update(old);
            _context.SaveChanges();
        }

        public List<OS> GetProducts(int id)
        {
            return _context.oS.Where(x => x.ProductId == id).ToList();
        }
    }
}
