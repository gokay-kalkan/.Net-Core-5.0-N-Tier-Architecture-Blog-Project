using Blog.UI.Models;

using EntityLayer.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Blog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class AdminController : Controller
    {
        private UserManager<UserAdmin> _userManager;
        private RoleManager<AppRole> _roleManager;
        private SignInManager<UserAdmin> _signInManager;
        private IConfiguration _conf;

        public AdminController(UserManager<UserAdmin> userManager, RoleManager<AppRole> roleManager, SignInManager<UserAdmin> signInManager,IConfiguration conf)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _conf = conf;
        }
        [Authorize (Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult Login()
        {
            return View(new UI.Models.LoginModel());
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UI.Models.LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.Username);
            
            if (user==null)
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
                HttpContext.Session.SetString("user", user.UserName);
                HttpContext.Session.SetString("token",GenerateJwtToken(user));
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
     
        public IActionResult GoogleLogin(string ReturnUrl)
        {
            string RedirectUrl = Url.Action("ExternalResponse","Admin", new { Area="Admin", ReturnUrl = ReturnUrl });

            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", RedirectUrl);
            return new ChallengeResult("Google", properties);

        }
     
     public async Task<IActionResult> ExternalResponse(string ReturnUrl="/")
        {
            ExternalLoginInfo info = await _signInManager.GetExternalLoginInfoAsync();

            if (info==null)
            {
                return RedirectToAction("Login");
            }

            else
            {
                SignInResult result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
                
                if (result.Succeeded)
                {
                    return Redirect(ReturnUrl);
                }
                

                else
                {
                    UserAdmin user = new UserAdmin();

                   user.Email = info.Principal.FindFirst(ClaimTypes.Email).Value;

                    string externalUserId = info.Principal.FindFirst(ClaimTypes.NameIdentifier).Value;

                    if (info.Principal.HasClaim(x => x.Type == ClaimTypes.Name))
                    {
                        string username = info.Principal.FindFirst(ClaimTypes.Name).Value;
                        username = username.Replace(' ', '-').ToLower() + externalUserId.Substring(0, 5).ToString();
                        user.UserName = username;
                    }

                    AppRole role = new AppRole()
                    {
                        Name = "Admin",
                        Status = true
                    };

                    await _roleManager.CreateAsync(role);
                    IdentityResult createresult = await _userManager.CreateAsync(user);

                    var resultt = await _userManager.AddToRoleAsync(user, role.Name);
                  



                    if (createresult.Succeeded)
                    {
                        IdentityResult loginresult = await _userManager.AddLoginAsync(user, info);

                        if (loginresult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                        else
                        {
                            foreach (var item in loginresult.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }

                    else
                    {
                        foreach (var item in createresult.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
               
            }

            return NotFound();

        }
        private string GenerateJwtToken(UserAdmin user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_conf.GetSection("AppSetting:Secret").Value);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

           
            return tokenHandler.WriteToken(token);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("FullName");

            return RedirectToAction("Login");
        }

    }
}
