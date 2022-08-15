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
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var list = cm.List(x => x.Status == true);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category data)
        {
            CategoryValidation validationRules = new CategoryValidation();
            ValidationResult result = validationRules.Validate(data);
            if (result.IsValid)
            {
                cm.Add(data);
                TempData["Success"] = "Kategori ekleme işlemi başarıyla gerçekleşti";
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
        public IActionResult Delete(int id)
        {
            var delete = cm.GetById(id);
            cm.Delete(delete);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteList()
        {
            var deletelist = cm.List(x => x.Status == false);
            return View(deletelist);
        }

        public IActionResult RestoreDeleted(int id)
        {
            var category = cm.GetById(id);
            cm.RestoreDeleted(category);
            TempData["RestoreDeleted"] = "Silinen kategori başarıyla geri yüklendi";
            return RedirectToAction("Index");
        }

        public IActionResult FullDelete(int id)
        {
            var category = cm.GetById(id);
            cm.FullDelete(category);
            TempData["FullDelete"] = "Kategori tamamen silindi";
            return RedirectToAction("DeleteList");
        }
        public IActionResult Update(int id)
        {
            var update = cm.GetById(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Category data)
        {
            CategoryValidation validationRules = new CategoryValidation();
            ValidationResult result = validationRules.Validate(data);
            if (result.IsValid)
            {
                cm.Update(data);
                TempData["Update"] = "Kategori güncelleme işlemi başarıyla gerçekleşti";
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
