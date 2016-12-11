using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Business.Components.Definition
{
    public interface IAuthenticationComponent
    {
        string Authenticate(string userName, string passWord);
    }
}
