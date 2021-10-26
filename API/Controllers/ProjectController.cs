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
    public class ProjectController : Controller
    {
        private readonly ICard<ProjectCard> _projectCard;

        public ProjectController(ICard<ProjectCard> projectCard)
        {
            _projectCard = projectCard;
        }
        [HttpGet]
        public IEnumerable<ProjectCard> GetProjects()
        {
            return _projectCard.GetCards();
        }
        [Route("{id}")]
        public ProjectCard GetProjectCard(int? id)
        {
            return _projectCard.GetCardOnId(id);
        }
    }
}
