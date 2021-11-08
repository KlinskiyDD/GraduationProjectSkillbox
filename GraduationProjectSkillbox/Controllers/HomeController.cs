using GraduationProjectSkillbox.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Data;
using GraduationProjectSkillbox.Domain.Interface;
using GraduationProjectSkillbox.Domain.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json.Linq;

namespace GraduationProjectSkillbox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICard<BlogCard> _blogCard;
        private readonly ICard<ProjectCard> _projectCard;
        private HttpClient client = new HttpClient();
        public string Token { get; set; }
        public CookieCollection CookieCollection { get; set; }

        public HomeController(ILogger<HomeController> logger, ICard<BlogCard> blogCard, ICard<ProjectCard> projectCard)
        {
            _logger = logger;
            _blogCard = blogCard;
            _projectCard = projectCard;
            CookieCollection = new CookieCollection();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View(_blogCard.GetCards());
        }
        [Authorize]
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task Login(UserCredential model)
        {
            HttpResponseMessage response =
                await client.PostAsJsonAsync(@"https://localhost:44318/api/Token/Authenticate", model);
            Token = response.Content.ReadAsStringAsync().Result;
            Response.Cookies.Append(model.UserName, Token);
            
        }
        public string Test()
        {
            WebRequest request = WebRequest.Create("https://localhost:44318/api/Name/GetNames");
            request.Method = "GET";
            var token = Request.Cookies["Admin"];
            request.Headers.Add("Authorization", "Bearer " + token);

            WebResponse response = request.GetResponse();
            string myResponse = String.Empty;
            using (StreamReader sr =  new StreamReader(response.GetResponseStream()))
            {
                myResponse = sr.ReadToEnd();
            }

            return myResponse;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
