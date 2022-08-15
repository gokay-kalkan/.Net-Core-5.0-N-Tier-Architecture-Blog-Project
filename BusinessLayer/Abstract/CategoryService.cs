﻿using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface CategoryService:GenericService<Category>
    {
        void RestoreDeleted(Category p);
        void FullDelete(Category p);
    }
}
