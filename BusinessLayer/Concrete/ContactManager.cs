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
    public class ContactManager : ContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact p)
        {
            p.CheckStatus = false;
            p.Date = DateTime.Now;
            _contactDal.Add(p);
        }

        public List<Contact> ContactList()
        {
            return _contactDal.List(x => x.CheckStatus == false);
        }

        public void Delete(Contact p)
        {
            _contactDal.Delete(p);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> List()
        {
            return _contactDal.List();
        }

        public List<Contact> List(Expression<Func<Contact, bool>> filter)
        {
            return _contactDal.List(filter);
        }

        public void Update(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}
