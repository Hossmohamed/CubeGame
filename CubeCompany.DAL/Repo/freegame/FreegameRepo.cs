using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.freegame;
using CubeGame.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.freegame
{
    public class FreegameRepo : IFreegameRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public FreegameRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }

        public List<Freegame> GetAll()
        {
            return _context.Freegames.Include(i => i.Images).Include(c => c.Category).ToList();
        }
    }
}
