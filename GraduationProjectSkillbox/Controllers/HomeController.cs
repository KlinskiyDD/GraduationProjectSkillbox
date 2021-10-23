using GraduationProjectSkillbox.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Interface;

namespace GraduationProjectSkillbox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICard<BlogCard> _blogCard;
        private readonly ICard<ProjectCard> _projectCard;

        public HomeController(ILogger<HomeController> logger, ICard<BlogCard> blogCard, ICard<ProjectCard> projectCard)
        {
            _logger = logger;
            _blogCard = blogCard;
            _projectCard = projectCard;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View(_blogCard.GetCards());
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
