﻿using CubeGame.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.newrelease
{
    public interface INewreleaseRepo
    {
        public List<Newrelease> GetAll();

    }
}
