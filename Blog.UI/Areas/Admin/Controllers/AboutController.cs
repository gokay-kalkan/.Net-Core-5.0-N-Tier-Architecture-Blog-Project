using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Entities;
using FluentValidation.Results;
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
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var list = am.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(About data)
        {
            AboutValidation validationRules = new AboutValidation();
            ValidationResult result = validationRules.Validate(data);
            if (result.IsValid)
            {
                am.Add(data);
                return RedirectToAction("Index");
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
        public IActionResult Update(int id)
        {
            var update = am.GetById(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(About data)
        {
            AboutValidation validationRules = new AboutValidation();
            ValidationResult result = validationRules.Validate(data);
            if (result.IsValid)
            {
                var update = am.GetById(data.AboutId);
                am.Update(update);
                return RedirectToAction("Index");
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
