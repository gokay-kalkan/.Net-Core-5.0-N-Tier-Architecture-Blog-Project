using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class IstatisticController : Controller
    {
        DataContext db = new DataContext();

        private UserManager<UserAdmin> _userManager;
        private RoleManager<AppRole> _roleManager;
        private SignInManager<UserAdmin> _signInManager;

        public IstatisticController(UserManager<UserAdmin> userManager, RoleManager<AppRole> roleManager, SignInManager<UserAdmin> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            var blogratingencok = db.Blogs.Where(x => x.Rating == (db.Blogs.GroupBy(x => x.Rating).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault())).Select(x => x.Name).ToList();
            ViewBag.blogratingencok = blogratingencok;

            var blogratingenaz = db.Blogs.Where(x => x.Rating == (db.Blogs.GroupBy(x => x.Rating).OrderBy(x => x.Count()).Select(y => y.Key).FirstOrDefault())).Select(x => x.Name).ToList();
            ViewBag.blogratingenaz = blogratingenaz;

            var commentencok = db.Blogs.Where(x => x.BlogId == (db.Comments.GroupBy(x => x.BlogId).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault())).Select(y => y.Name).FirstOrDefault();
            ViewBag.comemntencok = commentencok;

            var commentenaz = db.Blogs.Where(x => x.BlogId == (db.Comments.GroupBy(x => x.BlogId).OrderBy(x => x.Count()).Select(y => y.Key).FirstOrDefault())).Select(y => y.Name).FirstOrDefault();
            ViewBag.comemntenaz = commentenaz;

            var categoryblog = db.Categories.Where(x => x.CategoryId == db.Blogs.GroupBy(x => x.CategoryId).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault()).Select(y => y.Name).FirstOrDefault();

            ViewBag.categoryblog = categoryblog;

            var blogreadcount = db.Blogs.OrderByDescending(x => x.ReadCount).Select(y => y.Name).FirstOrDefault();
            ViewBag.blogreadcount = blogreadcount;

            var blogcount = db.Blogs.Count();
            ViewBag.blogcount = blogcount;

            var categorycount = db.Categories.Count();
            ViewBag.categorycount = categorycount;

            var commentcount = db.Comments.Count();
            ViewBag.commentcount = commentcount;

            IdentityRole role = new IdentityRole();
            role.Name = "Author";
            var roleauthor = _userManager.GetUsersInRoleAsync(role.ToString()).Result;

            ViewBag.authorcount=roleauthor.Count();
            

            return View();
        }
    }
}
