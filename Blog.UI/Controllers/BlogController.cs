using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Data;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        CommentManager cm = new CommentManager(new EfCommentDal());
        DataContext db = new DataContext();
        public IActionResult BlogList()
        {
            var list = bm.List(x => x.Status == true);
            return View(list);
        }
        public IActionResult BlogDetails(int id)
        {
          
            var detail = bm.GetById(id);
            detail.ReadCount +=1;
            
            bm.Update(detail);
            var blogcomment = cm.List(x => x.BlogId == id && x.CommentCheckStatus==true);
            ViewBag.commentlist = blogcomment;
            var commentcount = cm.List(x => x.BlogId == id && x.CommentCheckStatus==true).Count();
            ViewBag.sayi = commentcount;
            var ortalama = cm.List(x => x.BlogId == id && x.CommentCheckStatus==true).Select(x => x.BlogRating).DefaultIfEmpty(0).Average();
            ViewBag.ortalama = Math.Round(ortalama);
            
            return View(detail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BlogDetails(Comment data)
        {
            CommentValidation validationRules = new CommentValidation();
            ValidationResult result = validationRules.Validate(data);

           
            if (result.IsValid)
            {

                var blog = bm.GetById(data.BlogId);
                blog.Rating = data.BlogRating;
                bm.Update(blog);

                cm.Add(data);
               


                return RedirectToAction("BlogDetails");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(data);
        }

       
    }
}
