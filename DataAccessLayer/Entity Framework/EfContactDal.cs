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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        DataContext db = new DataContext();
        public void CheckStatus(Contact data)
        {
            var contact = db.Contacts.Find(data.ContactId);
            contact.CheckStatus = true;
            db.Contacts.Update(contact);
            db.SaveChanges();
        }
    }
}
