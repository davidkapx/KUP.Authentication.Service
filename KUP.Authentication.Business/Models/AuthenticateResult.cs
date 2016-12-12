using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Business.Models
{
    public class AuthenticateResult
    {
        public string LoginResult { get; set; }
        public string JWT_Token { get; set; }
    }
}
