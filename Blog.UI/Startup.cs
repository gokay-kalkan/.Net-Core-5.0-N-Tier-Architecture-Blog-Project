using Blog.UI.Areas.Identity;
using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
          options.AddPolicy("default",builder =>
           builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().WithOrigins("https://localhost:5001", "https://localhost:44362", "https://localhost:44315").WithHeaders().WithMethods()));

            services.AddAuthentication().AddGoogle(opts =>
            {

                opts.ClientId = "753828162267-0js84g71m925aqj398tj2gbv5jtfeoc0.apps.googleusercontent.com";
                opts.ClientSecret = "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";
            });
            services.AddAuthorization();

            services.AddControllersWithViews();
            services.AddDbContext<DataContext>();
            
            services.AddIdentity<UserAdmin, AppRole>().AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();
           
            services.Configure<IdentityOptions>(opt =>
            {
                
                opt.SignIn.RequireConfirmedAccount = false;
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.User.AllowedUserNameCharacters = "abcçdefgðhýijklmnroöprsþtuüvyzABCÇDEFGÐHIÝJKLMNROÖPRSÞTUÜVYZ0123456789-._";
            });

            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = "/Admin/Admin/Login";
                opt.LogoutPath = "/Admin/Admin/LogOut";
                opt.AccessDeniedPath = "/Account/AccessDenied";
               
            });
         
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<UserAdmin>userManager,RoleManager<AppRole>roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("default");
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Author}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            SeedIdentity.Seed(userManager, roleManager);
        }
    }
}
