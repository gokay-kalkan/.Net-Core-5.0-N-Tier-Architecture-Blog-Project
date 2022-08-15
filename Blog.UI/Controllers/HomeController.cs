using Blog.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blog.UI.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Post()
        {
            var captchaImage = HttpContext.Request.Form["g-recaptcha-response"];

            if (string.IsNullOrEmpty(captchaImage))
            {
                return Content("Doldurulmadı");
            }

            var verified = await CheckCaptcha();

            if (!verified)
            {
                return Content("Doğrulanmadı");
            }
            if (verified)
            {
                return Content("Başarıyla Doğrulandı");
            }

            return View();
        }
        public async Task<bool> CheckCaptcha()
        {
            var postData = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("secret", "6Ldw-4AfAAAAAJDqknWzONTJVeoRZ9D1SVxY-ZXd"),
                new KeyValuePair<string, string>("response", HttpContext.Request.Form["g-recaptcha-response"])

            };

            var client = new HttpClient();

            var response = await client.PostAsync("https://www.google.com/recaptcha/api/siteverify", new FormUrlEncodedContent(postData));

            var o= (JObject)JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());

            return (bool)o["success"];

        }
    }
}
