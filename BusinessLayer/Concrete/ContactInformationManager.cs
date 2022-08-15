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
    public class ContactInformationManager : ContactInformationService
    {
        IContactInformationDal _contactInformationDal;

        public ContactInformationManager(IContactInformationDal contactInformationDal)
        {
            _contactInformationDal = contactInformationDal;
        }

        public void Add(ContactInformation p)
        {
            _contactInformationDal.Add(p);
        }

        public void Delete(ContactInformation p)
        {
            _contactInformationDal.Delete(p);
        }

        public ContactInformation GetById(int id)
        {
            return _contactInformationDal.GetById(id);
        }

        public List<ContactInformation> List()
        {
            return _contactInformationDal.List();
        }

        public List<ContactInformation> List(Expression<Func<ContactInformation, bool>> filter)
        {
            return _contactInformationDal.List(filter);
        }

        public void Update(ContactInformation p)
        {
            _contactInformationDal.Update(p);
        }
    }
}
