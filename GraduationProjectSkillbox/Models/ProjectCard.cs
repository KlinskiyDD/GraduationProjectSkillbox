using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProjectSkillbox.Models
{
    public class ProjectCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class NullProjectCard : ProjectCard
    {
        public NullProjectCard()
        {
            Id = 0;
            Title = "Нет";
            Description = "Нет";
            Image = "Нет";
        }
    }
}
