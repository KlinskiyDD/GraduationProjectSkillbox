using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Domain.Interface;
using GraduationProjectSkillbox.Domain.Models;
using Newtonsoft.Json;

namespace GraduationProjectSkillbox.Data
{
    public class BlogAPI:ICard<BlogCard>
    {
        private HttpClient httpClient { get; set; }

        public BlogAPI()
        {
            httpClient = new HttpClient();
        }

        public IEnumerable<BlogCard> GetCards()
        {
            var url = @"https://localhost:44318/api/blog";
            var json = httpClient.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<IEnumerable<BlogCard>>(json);
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
            var url = @"https://localhost:44318/api/blog/" + id;
            var json = httpClient.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<BlogCard>(json);
        }
    }
}
