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
    public class CategoryManager : CategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category p)
        {
            p.Status = true;
            _categoryDal.Add(p);
        }

        public void Delete(Category p)
        {
            var delete = _categoryDal.GetById(p.CategoryId);
            delete.Status = false;
            _categoryDal.Update(delete);
           
        }

        public void FullDelete(Category p)
        {
            var category = _categoryDal.GetById(p.CategoryId);
            _categoryDal.FullDelete(category);
        }

        public Category GetById(int id)
        {
           return  _categoryDal.GetById(id);
        }

        public List<Category> List()
        {
            return _categoryDal.List();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.List(filter);
        }

        public void RestoreDeleted(Category p)
        {
            var category = _categoryDal.GetById(p.CategoryId);
            category.Status = true;
            _categoryDal.Update(category);
        }

        public void Update(Category p)
        {
            var update = _categoryDal.GetById(p.CategoryId);
            update.Name = p.Name;

            _categoryDal.Update(update);
        }
    }
}
