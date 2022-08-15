using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Identity
{
    public class SeedIdentity
    {
        public static void Seed(UserManager<UserAdmin>userManager,RoleManager<AppRole>roleManager)
        {
            var user = new UserAdmin()
            {
                UserName = "admin",
                Email = "gky.klkn@gmail.com",
                FullName = "Admin Admin"
            };

            if (userManager.FindByNameAsync("Admin Admin").Result==null)
            {
                var identityResult = userManager.CreateAsync(user,"admin123456").Result;
            }
            if (roleManager.FindByNameAsync("Admin").Result==null)
            {
                AppRole role = new AppRole()
                {
                    Name = "Admin"
                };
                var identityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(user, role.Name).Result;
            }

        }
    }
}
