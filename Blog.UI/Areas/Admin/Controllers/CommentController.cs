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
    [Authorize(Roles ="Admin")]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            var commentlist = cm.List();
            return View(commentlist);
        }

        public IActionResult CommentUpdate(int id)
        {
            var comment = cm.GetById(id);
            return View(comment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CommentUpdate(Comment data)
        {
            var comment = cm.GetById(data.CommentId);
            cm.CommentCheckUpdate(comment);
            return RedirectToAction("Index");
        }
    }
}
