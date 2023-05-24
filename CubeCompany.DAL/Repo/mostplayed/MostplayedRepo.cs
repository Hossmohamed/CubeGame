using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.mostplayed
{
    public class MostplayedRepo : IMostplayedRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public MostplayedRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }

        public List<Mostplayed> GetAll()
        {
            return _context.Mostplayeds.Include(i => i.Images).Include(c => c.Category).ToList();
        }
    }
   
}
