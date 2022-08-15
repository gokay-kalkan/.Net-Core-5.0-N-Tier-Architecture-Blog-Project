using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            var list = cm.List();
            return View(list);
        }

     public IActionResult Confirm(int id)
        {
            var contact = cm.GetById(id);
            contact.CheckStatus = true;
            cm.Update(contact);
            return RedirectToAction("Index");
        }
    }
}
