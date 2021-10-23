using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Interface;
using GraduationProjectSkillbox.Models;

namespace GraduationProjectSkillbox.Repository
{
    public class BlogRep:ICard<BlogCard>
    {
        private static List<BlogCard> blogCards;

        static BlogRep()
        {
            blogCards= new List<BlogCard>()
            {
                new BlogCard(){Id = 0,
                    Title = "Как уменьшить затраты на ИТ поддержку вашего бизнеса.",
                    Description = "Эта статья будет полезна тем, кто хочет сократить расходы на ИТ без потерь в качестве обслуживания.",
                    Image = @"/assets/img/blog-1.jpg",Time = new DateTime(2021,10,20)},
                new BlogCard(){Id = 1,
                    Title = "Как сохранить данные, не потеряв в деньгах. Часть 1.",
                    Description = "Эта статья будет полезна тем, кто пытается понять, как в современных реалиях надёжно хранить рабочие данные, результаты и другую значимую информацию для бизнеса.",
                    Image = @"/assets/img/blog-2.jpg",Time = new DateTime(2021,07,8)},
                new BlogCard(){Id = 2,Title = "Как сохранить данные, не потеряв в деньгах. Часть 2.",
                    Description = "Продолжение статьи о современных способах и средствах надёжного хранения данных для малого бизнеса.",
                    Image = @"/assets/img/blog-3.jpg",Time = new DateTime(2021,04,19)},
                new BlogCard(){Id = 3,
                    Title = "Как телефонизировать офис не переплатив. Часть 1.",
                    Description = "Эта статья поможет вам понять основные сведения о IP Телефонии для планирования расходов при телефонизации и дальнейшей работе.",
                    Image = @"/assets/img/blog-4.jpg",Time = new DateTime(2021,02,14)},
            };
        }
        public IEnumerable<BlogCard> GetCards()
        {
            return blogCards;
        }

        public void AddCard(BlogCard value)
        {
            throw new NotImplementedException();
        }

        public void DeleteCard(BlogCard value)
        {
            throw new NotImplementedException();
        }

        public void EditCard(BlogCard value)
        {
            throw new NotImplementedException();
        }

        public BlogCard GetCardOnId(int? id)
        {
            if (id < blogCards.Count)
            {
                return blogCards[id.Value];
            }
            
            return new NullBlogCard();
        }
    }
}
