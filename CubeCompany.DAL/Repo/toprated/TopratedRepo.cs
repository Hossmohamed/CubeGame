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

namespace CubeGame.DAL.Repo.toprated
{
    public class TopratedRepo : ITopratedRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public TopratedRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }

        public List<Toprated> GetAll()
        {
            return _context.Toprateds.Include(i => i.Images).Include(c => c.Category).ToList();
        }
    }

}
