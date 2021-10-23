using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProjectSkillbox.Models
{
    public class BlogCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Time { get; set; }
    }

    public class NullBlogCard : BlogCard
    {
        public NullBlogCard()
        {
            Id = 0;
            Title = "Нет";
            Description = "Нет";
            Image = "Нет";
            Time = new DateTime(0001,1,1);
        }
    }
}
