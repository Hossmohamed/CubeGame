using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.onsale
{
    public class OnsaleRepo : IOnsaleRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public OnsaleRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }
        
        public List<Onsale> GetAll()
        {
            return _context.Onsales.Include(i => i.Images).Include(c => c.category).ToList();
        }
        
    }
}
