using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using GraduationProjectSkillbox.Domain.Models;
using GraduationProjectSkillbox.Logic.Context;
using GraduationProjectSkillbox.Logic.Interface;
using GraduationProjectSkillbox.Logic.Services;

namespace WebAPI.Controllers
{
    public class ProjectController : ApiController
    {
        private ICard<ProjectCard> _card = new ProjectCardServices();

        public IHttpActionResult GetAll()
        {
            return Ok(_card.GetCards());
        }

        public IHttpActionResult GetOnId(int id)
        {
            return Ok(_card.GetCardOnId(id));
        }
    }
}
