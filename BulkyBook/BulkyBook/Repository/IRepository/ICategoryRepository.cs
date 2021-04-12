﻿using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBook.Repository.IRepository
{
   public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
