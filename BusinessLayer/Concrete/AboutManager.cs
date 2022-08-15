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
    public class AboutManager : AboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About p)
        {
           
            _aboutDal.Add(p);
        }

        public void Delete(About p)
        {
            _aboutDal.Delete(p);
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> List()
        {
            return _aboutDal.List();
        }

        public List<About> List(Expression<Func<About, bool>> filter)
        {
            return _aboutDal.List(filter);
        }

        public void Update(About p)
        {
            var update = _aboutDal.GetById(p.AboutId);
            update.Description = p.Description;
            _aboutDal.Update(update);
        }
    }
}
