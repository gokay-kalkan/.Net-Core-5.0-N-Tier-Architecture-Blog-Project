using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Data;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity_Framework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        DataContext db = new DataContext();

      

        public void FullDelete(Blog p)
        {
            var blog = db.Blogs.Find(p.BlogId);
            db.Blogs.Remove(blog);
            db.SaveChanges();
        }

        public List<Blog> ThreeBlog()
        {
            return db.Blogs.Where(x => x.Status == true).OrderByDescending(x => x.BlogId).Take(3).ToList();
        }
    }
}
