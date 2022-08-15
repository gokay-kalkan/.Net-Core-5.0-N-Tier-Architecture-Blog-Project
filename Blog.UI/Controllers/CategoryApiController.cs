using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Controllers
{
   [Authorize]
    public class CategoryApiController : Controller
    {
        
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var httpClient = new HttpClient();

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");

            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token").ToString());

            var request = httpClient.GetAsync("https://localhost:5001/api/Category").Result;

            var response = request.Content.ReadAsStringAsync().Result;

            var values = JsonConvert.DeserializeObject<List<Category>>(response);
            return View(values);
        }

       public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category data)
        {
            var httpClient = new HttpClient();

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");

            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token").ToString());
           
            var category = JsonConvert.SerializeObject(data);

            StringContent content = new StringContent(category, Encoding.UTF8, "application/json");

            var request = await httpClient.PostAsync("https://localhost:5001/api/Category", content);


            return RedirectToAction("Index");
        }
       
        public IActionResult Delete(int id)
        {
            var httpClient = new HttpClient();

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");

            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token").ToString());
            var request = httpClient.DeleteAsync($"https://localhost:5001/api/Category/{id}").Result;

            return RedirectToAction("Index");

        }

        public IActionResult Update(int id)
        {
            var httpClient = new HttpClient();
            

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");

            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token").ToString());
            var request = httpClient.GetAsync($"https://localhost:5001/api/Category/{id}").Result;
            if (request.IsSuccessStatusCode)
            {
              
                var category = JsonConvert.DeserializeObject<Category>(request.Content.ReadAsStringAsync().Result);
                return View(category);
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult Update(Category data)
        {
            var httpClient = new HttpClient();

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");

            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token").ToString());

            var category = JsonConvert.SerializeObject(data);



            StringContent content = new StringContent(category, Encoding.UTF8, "application/json");
            var request = httpClient.PutAsync("https://localhost:5001/api/Category",content).Result;

            return RedirectToAction("Index");

        }
        public IActionResult VueGet()
        {
           
            return View();
        }
    }
}
