using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Domain.Interface;
using GraduationProjectSkillbox.Domain.Models;
using Microsoft.AspNetCore.Authorization;

namespace GraduationProjectSkillbox.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ICard<ProjectCard> _projectCard;

        public ProjectController(ICard<ProjectCard> projectCard)
        {
            _projectCard = projectCard;
        }
        public IActionResult Projects()
        {
            return View(_projectCard.GetCards());
        }
        public IActionResult ProjectCard(int? id)
        {
            return View(_projectCard.GetCardOnId(id));
        }
    }
}
