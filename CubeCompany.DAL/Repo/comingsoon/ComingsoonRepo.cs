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

namespace CubeGame.DAL.Repo.comingsoon
{
    public class ComingsoonRepo : IComingsoonRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public ComingsoonRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }

        public List<Comingsoon> GetAll()
        {
            return _context.Comingsoons.Include(i => i.Images).Include(c => c.Category).ToList();
        }
    }
}
