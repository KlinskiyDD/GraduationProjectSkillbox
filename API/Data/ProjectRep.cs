using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Domain.Interface;
using GraduationProjectSkillbox.Domain.Models;

namespace API.Data  
{
    public class ProjectRep:ICard<ProjectCard>
    {
        private static List<ProjectCard> projectCards;

        static ProjectRep()
        {
            projectCards = new List<ProjectCard>()
            {
                new ProjectCard()
                {
                    Id = 0,
                    Title = "Обработка кредитных запросов в режиме онлайн",
                    Description = "Какое-то описание для СБЕРБАНКА",
                    Image = "/assets/img/sberbank.jpg"
                },
                new ProjectCard()
                {
                    Id = 1,
                    Title = "Управление кадрами и расчет зарплаты",
                    Description = "Какое-то описание для МЯСНИЦКОГО РЯДА",
                    Image = "/assets/img/myasko.jpg"
                },
                new ProjectCard()
                {
                    Id = 2,
                    Title = "Доработка CRM и корпоративного интернет-магазина",
                    Description = "Какое-то описание для ЧИТАЙ ГОРОДА",
                    Image = "/assets/img/readcity.jpg"
                }
            };
        }
        public IEnumerable<ProjectCard> GetCards()
        {
            return projectCards;
        }

        public void AddCard(ProjectCard value)
        {
            throw new NotImplementedException();
        }

        public void DeleteCard(ProjectCard value)
        {
            throw new NotImplementedException();
        }

        public void EditCard(ProjectCard value)
        {
            throw new NotImplementedException();
        }

        public ProjectCard GetCardOnId(int? id)
        {
            return projectCards[id.Value];
        }
    }
}
