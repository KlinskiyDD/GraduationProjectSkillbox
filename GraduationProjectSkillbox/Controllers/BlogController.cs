using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Interface;
using GraduationProjectSkillbox.Models;

namespace GraduationProjectSkillbox.Controllers
{
    public class BlogController : Controller
    {
        private readonly ICard<BlogCard> _blogCard;

        public BlogController(ICard<BlogCard> blogCard)
        {
            _blogCard = blogCard;
        }
        public IActionResult Blog()
        {
            return View(_blogCard.GetCards());
        }
        public IActionResult BlogCard(int? id)
        {
            return View(_blogCard.GetCardOnId(id));
        }

        public IActionResult MyTest()
        {
            return Redirect("/Blog/Blog");
        }
    }
}
