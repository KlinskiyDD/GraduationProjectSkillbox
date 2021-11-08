using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProjectSkillbox.Data
{
    public interface ILog
    {
        string Authentication(string userName, string password);
    }
}
