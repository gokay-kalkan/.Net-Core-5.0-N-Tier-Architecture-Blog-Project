using Blog.UI.Areas.Admin.Models;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoleManagementController : Controller
    {
        private RoleManager<AppRole> _roleManager;

        public RoleManagementController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.Where(x=>x.Status==true).ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            
            return View(new RoleViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoleViewModel model)
        {
            AppRole identityRole = new AppRole();
            identityRole.Name = model.Name;
            identityRole.Status = true;
            

            IdentityResult result = await _roleManager.CreateAsync(identityRole);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var delete = await _roleManager.FindByIdAsync(id);
            delete.Status = false;
            await _roleManager.UpdateAsync(delete);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteRoles()
        {
            var roles = _roleManager.Roles.Where(x=>x.Status==false).ToList();
            return View(roles);
           
        }

        public async Task<IActionResult> RoleActiveAdd(string id)
        {
            var delete = await _roleManager.FindByIdAsync(id);
            delete.Status = true;
            await _roleManager.UpdateAsync(delete);

            return RedirectToAction("Index");
        }




    }
}
