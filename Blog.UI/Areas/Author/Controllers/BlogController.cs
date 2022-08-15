using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Entity_Framework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Author.Controllers
{
    [Area("Author")]
    [Authorize(Roles ="Author")]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        IWebHostEnvironment _env;
        public BlogController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            var sessionuser = HttpContext.Session.GetString("Id");
            var list = bm.List(x => x.Status == true && x.UserAdminId == sessionuser);
            return View(list);
        }

        public IActionResult Create()
        {
            DropDown();
            ViewBag.useradminid = HttpContext.Session.GetString("Id");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EntityLayer.Entities.Blog data)
        {
            DropDown();
            BlogValidation validationRules = new BlogValidation();
            ValidationResult result = validationRules.Validate(data);
            var sessionuser = HttpContext.Session.GetString("Id");
            if (sessionuser.ToString() == data.UserAdminId)
            {
                if (result.IsValid)
                {
                    var filepath = Path.Combine(_env.WebRootPath, "img");
                    var fullfilepath = Path.Combine(filepath, data.Image.FileName);
                    using (var filestream = new FileStream(fullfilepath, FileMode.Create))
                    {
                        data.Image.CopyTo(filestream);
                    }
                    data.BlogImage = data.Image.FileName;
                    bm.Add(data);
                    TempData["Success"] = "Blog ekleme işlemi başarıyla gerçekleşti";
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
            }

            return View(data);
        }

        public IActionResult Delete(int id)
        {
            var sessionuser = HttpContext.Session.GetString("Id");

            var delete = bm.GetById(id);
            if (sessionuser.ToString() == delete.UserAdminId)
            {
                bm.Delete(delete);
                return RedirectToAction("Index");
            }
            return View(delete);




        }
        public IActionResult RestoreDeleted(int id)
        {
            var sessionuser = HttpContext.Session.GetString("Id");
            var blog = bm.GetById(id);
            if (sessionuser.ToString() == blog.UserAdminId)
            {
                bm.RestoreDeleted(blog);
                TempData["RestoreDeleted"] = "Silinen blog başarıyla geri yüklendi";
                return RedirectToAction("Index");
            }
            return View(blog);

        }
        public IActionResult DeleteList()
        {
            var deletelist = bm.List(x => x.Status == false);
            return View(deletelist);
        }

        public IActionResult FullDelete(int id)
        {
            var sessionuser = HttpContext.Session.GetString("Id");
            var blog = bm.GetById(id);
            if (sessionuser.ToString() == blog.UserAdminId)
            {
                bm.FullDelete(blog);
                TempData["FullDelete"] = "Blog tamamen silindi";
                return RedirectToAction("DeleteList");
            }
            return View(blog);
        }

        public IActionResult Update(int id)
        {
            ViewBag.useradminid = HttpContext.Session.GetString("Id");
            DropDown();
            var blog = bm.GetById(id);

            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(EntityLayer.Entities.Blog data)
        {
            DropDown();
            var sessionuser = HttpContext.Session.GetString("Id");
            if (sessionuser.ToString() == data.UserAdminId)
            {
                if (data.Image != null)
                {
                    var filepath = Path.Combine(_env.WebRootPath, "img");
                    var fullfilepath = Path.Combine(filepath, data.Image.FileName);
                    using (var filestream = new FileStream(fullfilepath, FileMode.Create))
                    {
                        data.Image.CopyTo(filestream);
                    }

                    bm.Update(data);

                    bm.BlogImageUpdate(data);

                    TempData["Update"] = "Blog Güncelleme işlemi başarıyla gerçekleşti";
                    return RedirectToAction("Index");
                }
                else
                {

                    bm.Update(data);
                    TempData["Update"] = "Blog Güncelleme işlemi başarıyla gerçekleşti";
                    return RedirectToAction("Index");
                }
            }
            return View(data);


        }

        public void DropDown()
        {
            List<SelectListItem> value = (from x in cm.List(x => x.Status == true)

                                          select new SelectListItem
                                          {
                                              Value = x.CategoryId.ToString(),
                                              Text = x.Name
                                          }).ToList();
            ViewBag.category = value;


        }
    }
}
