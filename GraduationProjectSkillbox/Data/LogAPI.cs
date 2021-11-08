using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Domain.Models;
using Newtonsoft.Json;

namespace GraduationProjectSkillbox.Data
{
    public class LogAPI:ILog
    {
        private HttpClient _httpClient { get; set; }

        public LogAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public string Authentication(string userName, string password)
        {
            var url = $@"https://localhost:44318/api/Token/Authentication/{userName}/{password}";
            var json = _httpClient.GetStringAsync(url).Result;
            return json;
        }
    }
}
