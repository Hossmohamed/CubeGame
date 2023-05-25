using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostplayed;
using CubeGame.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.topseller
{
    public class TopsellerRepo : ITopsellerRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public TopsellerRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }

        public List<Topseller> GetAll()
        {
            return _context.Topsellers.Include(i => i.Images).Include(c => c.Category).ToList();
        }
    }
}
