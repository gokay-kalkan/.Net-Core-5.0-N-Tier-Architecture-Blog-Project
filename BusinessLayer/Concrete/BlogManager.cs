using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.Concrete
{
    public class BlogManager : BlogService
    {
        IBlogDal _blogDal;
       

        public BlogManager(IBlogDal blogDal)
        {
           _blogDal = blogDal;
            
        }

        public void Add(Blog p)
        {
            p.Status = true;
            p.BlogDate = DateTime.Now;
            

            _blogDal.Add(p);
        }

        public void BlogImageUpdate(Blog p)
        {
            var blog = _blogDal.GetById(p.BlogId);
            blog.BlogImage = p.Image.FileName;
            _blogDal.Update(blog);
        }

       

        public void Delete(Blog p)
        {
            var delete=_blogDal.GetById(p.BlogId);
            delete.Status = false;

            _blogDal.Update(delete);
        }

        public void FullDelete(Blog p)
        {
            var blog  = _blogDal.GetById(p.BlogId);
            _blogDal.FullDelete(blog);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> List()
        {
            return _blogDal.List();
        }

        public List<Blog> List(Expression<Func<Blog, bool>> filter)
        {
            return _blogDal.List(filter);
        }

        public void RestoreDeleted(Blog p)
        {
            var blog = _blogDal.GetById(p.BlogId);
            blog.Status = true;
            _blogDal.Update(blog);
        }

        public List<Blog> ThreeBlog()
        {
            return _blogDal.ThreeBlog();
        }

        public void Update(Blog p)
        {
            var blog = _blogDal.GetById(p.BlogId);
            blog.Name = p.Name;
            blog.CategoryId = p.CategoryId;
            blog.Description = p.Description;
            blog.BlogDate = DateTime.Now;
            blog.Status = true;
            _blogDal.Update(blog);
        }
    }
}
