using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Models.LocalModels;
using WebAPI.Interface;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProjectController : ApiController
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
