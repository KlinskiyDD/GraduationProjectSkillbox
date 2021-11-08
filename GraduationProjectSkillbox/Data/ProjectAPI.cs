using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Domain.Interface;
using GraduationProjectSkillbox.Domain.Models;
using Newtonsoft.Json;

namespace GraduationProjectSkillbox.Data
{
    public class ProjectAPI:ICard<ProjectCard>
    {
        private HttpClient httpClient { get; set; }

        public ProjectAPI()
        {
            httpClient = new HttpClient();
        }

        public IEnumerable<ProjectCard> GetCards()
        {
            var url = @"https://localhost:44318/api/project";
            var json = httpClient.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<IEnumerable<ProjectCard>>(json);
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
            var url = @"https://localhost:44318/api/project/" + id;
            var json = httpClient.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<ProjectCard>(json);
        }
    }
}
