using Blog.UI.Areas.Admin.Models;
using Blog.UI.Areas.Author.Models;
using DataAccessLayer.Data;
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
    [Authorize(Roles ="Admin")]
    public class UserManagementController : Controller
    {
        private UserManager<UserAdmin> _userManager;
        private RoleManager<AppRole> _roleManager;
        DataContext db = new DataContext();

        public UserManagementController(UserManager<UserAdmin> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var list = _userManager.Users.Where(x=>x.Status==true).ToList();
            return View(list);
        }

        public IActionResult DeleteUsers()
        {
            var list = _userManager.Users.Where(x => x.Status == false).ToList();
            return View(list);
        }

        public async Task<IActionResult> UsersActive(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            user.Status = true;
           await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }


        public IActionResult UserCreate()
        {
           
            return View(new RegisterModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserCreate(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UserAdmin user = new UserAdmin()
            {
                Email = model.Email,
                UserName = model.UserName,
                FullName = model.FullName,
                Status=true
            };

            
           
            var result = await _userManager.CreateAsync(user, model.Password);
           

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                result.Errors.ToList().ForEach(x => ModelState.AddModelError("", x.Description));
                return View(model);
            }

        }

        public IActionResult UserDelete(string id)
        {
            var user = db.UserAdmins.Find(id);
            user.Status = false;
            _userManager.UpdateAsync(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RoleAssign(string id)
        {
            var user = await  _userManager.FindByIdAsync(id);


            TempData["UserId"] = id;

            ViewBag.FullName = user.FullName;

            IQueryable<AppRole> roles = _roleManager.Roles;

            List<string> useroles = _userManager.GetRolesAsync(user).Result as List<string>;

            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();

            foreach (var role in roles)
            {
                RoleAssignViewModel r = new RoleAssignViewModel();
                if (useroles.Contains(role.Name))
                {
                    r.Id = role.Id;
                    r.Name = role.Name;
                    r.Exist = true;
                }
                else
                {
                    r.Id = role.Id;
                    r.Name = role.Name;
                    r.Exist = false;
                }
                roleAssignViewModels.Add(r);
            }
            return View(roleAssignViewModels);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RoleAssign(List<RoleAssignViewModel> roleAssignViewModels)
        {
            UserAdmin user = _userManager.FindByIdAsync(TempData["UserId"].ToString()).Result;

            foreach (var item in roleAssignViewModels)
            {
                if (item.Exist==true)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }

            return RedirectToAction("Index");
        }
    }
}
