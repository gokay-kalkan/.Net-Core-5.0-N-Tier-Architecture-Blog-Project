using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Data;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity_Framework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        DataContext db = new DataContext();
        public void FullDelete(Category p)
        {
            var category = db.Categories.Find(p.CategoryId);
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
