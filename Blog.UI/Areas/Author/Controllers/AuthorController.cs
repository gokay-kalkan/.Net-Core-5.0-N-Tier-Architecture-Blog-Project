using Blog.UI.Areas.Author.Models;
using Blog.UI.Models;
using EntityLayer.Entities;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Author.Controllers
{
    [Area("Author")]

    public class AuthorController : Controller
    {
        private UserManager<UserAdmin> _userManager;
        private RoleManager<AppRole> _roleManager;
        private SignInManager<UserAdmin> _signInManager;

        public AuthorController(UserManager<UserAdmin> userManager, RoleManager<AppRole> roleManager, SignInManager<UserAdmin> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [Authorize(Roles = "Author")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
            }

            if (await _userManager.IsLockedOutAsync(user))
            {
                ModelState.AddModelError("", "Hesabınız bir süreliğine kilitlendi");
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true);

            if (result.Succeeded)
            {
                await _userManager.ResetAccessFailedCountAsync(user);
                HttpContext.Session.SetString("FullName", user.FullName);
                HttpContext.Session.SetString("Id", user.Id);
                return RedirectToAction("Index");
            }
            else
            {
                await _userManager.AccessFailedAsync(user);
                int fail = await _userManager.GetAccessFailedCountAsync(user);

                if (fail == 3)
                {
                    await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(2)));

                    ModelState.AddModelError("", "Hesabınız 3 başarısız girişten dolayı kilitlenmiştir");
                }
                else
                {
                    ModelState.AddModelError("", "Geçersiz eposta veya şifre");
                }



            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("FullName");

            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View(new RegisterModel());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UserAdmin user = new UserAdmin()
            {
                Email = model.Email,
                UserName = model.UserName,
                FullName = model.FullName
            };

            AppRole role = new AppRole()
            {
                Name = "Author",
                Status = true
            };

            await _roleManager.CreateAsync(role);

            var result = await _userManager.CreateAsync(user, model.Password);
            var resultt = await _userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded || resultt.Succeeded)
            {
                return RedirectToAction("Login");
            }
            else
            {
                result.Errors.ToList().ForEach(x => ModelState.AddModelError("", x.Description));
                return View(model);
            }

        }

        public IActionResult ResetPassword()
        {
            return View(new ResetPasswordModel());
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            UserAdmin user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                string resettoken = await _userManager.GeneratePasswordResetTokenAsync(user);

                string passwordresetlink = Url.Action("UpdatePassword", "Author", new { userId = user.Id, token = resettoken }, HttpContext.Request.Scheme);

                MailHelper.ResetPassword.PasswordSendMail(passwordresetlink);

                ViewBag.State = true;


            }
            else
            {
                ViewBag.State = false;
            }

            return View(model);
        }

        public IActionResult UpdatePassword(string userId, string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> UpdatePassword([Bind("NewPassword")]ResetPasswordModel model)
        {
            string token = TempData["token"].ToString();
            string userId = TempData["userId"].ToString();

            UserAdmin user = await _userManager.FindByIdAsync(userId);

            if (user!=null)
            {
                IdentityResult result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);

                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);

                    TempData["Success"] = "Başarıyla güncellenmiştir";
;                }
            }
            else
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
            }
            return View();
        }

        public IActionResult Profile()
        {
            UserAdmin user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            RegisterModel userViewModel = user.Adapt<RegisterModel>();
            return View(userViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Profile(RegisterModel model)
        {
            ModelState.Remove("Password");
            ModelState.Remove("RePassword");

            if (ModelState.IsValid)
            {
                UserAdmin user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.FullName = model.FullName;
                user.UserName = model.UserName;
                user.Email = model.Email;

                IdentityResult result = await  _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);

                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user,true);

                    ViewBag.success = "Kullanıcı bilgileri başarıyla güncellendi";
                  
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
               
            }
             return View(model);
        }

        public IActionResult ChangePassword()
        {
           
            return View(new ChangePasswordModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                UserAdmin user = await _userManager.FindByNameAsync(User.Identity.Name);
                bool exist = await _userManager.CheckPasswordAsync(user, model.OldPassword);
                if (exist)
                {
                    IdentityResult result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

                    if (result.Succeeded)
                    {
                        await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, model.NewPassword, true, false);

                        ViewBag.Success = "Şifreniz başarıyla güncellendi";
                    }

                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                    
                }

                else
                {
                    ModelState.AddModelError("", "Şifreniz yanlış");
                }
            }
            return View(model);
        }
    }
}
