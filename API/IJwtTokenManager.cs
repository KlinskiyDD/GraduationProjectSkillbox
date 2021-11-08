using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public interface IJwtTokenManager
    {
        string Authentication(string userName, string password);
    }
}
