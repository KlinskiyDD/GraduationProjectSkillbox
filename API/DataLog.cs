using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class DataLog
    {
        public static Dictionary<string, string> Users = new Dictionary<string, string>
        {
            {"User", "password"},
            {"Admin", "admin"},
            {"SampleUser","password"}
        };
    }
}
