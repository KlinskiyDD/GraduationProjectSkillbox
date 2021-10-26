using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interface;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly ICard<BlogCard> _blogCard;

        public BlogController(ICard<BlogCard> blogCard)
        {
            _blogCard = blogCard;
        }
        [HttpGet]
        public IEnumerable<BlogCard> GetBlogs()
        {
            return _blogCard.GetCards();
        }
        [Route("{id}")]
        public BlogCard GetBlogCard(int id)
        {
            return _blogCard.GetCardOnId(id);
        }

        //public IActionResult MyTest()
        //{
        //    return Redirect("/Blog/Blog");
        //}
    }
}
