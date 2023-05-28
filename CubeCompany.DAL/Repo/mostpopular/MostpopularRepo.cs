using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.category;
using CubeGame.DAL.Repo.mostpopular;
using CubeGame.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.mostpopular
{
    public class MostpopularRepo : IMostpopularRepo
    {
        private readonly ApplicationDBContext _context;
        ICategoryRepo IC;
        public MostpopularRepo(ApplicationDBContext context, ICategoryRepo iC)
        {
            _context = context;
            IC = iC;
        }

        public List<Mostpopular> GetAll()
        {
            return _context.Mostpopulars.Include(i => i.Images).Include(c => c.Category).ToList();
        }
    }
}
