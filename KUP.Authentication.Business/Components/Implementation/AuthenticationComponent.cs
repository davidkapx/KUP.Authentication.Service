using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KUP.Authentication.Data;
using KUP.Authentication.Business.Components.Definition;
using KUP.Authentication.Data.Repositories.Definition;

namespace KUP.Authentication.Business.Components.Implementation
{
    public class AuthenticationComponent : IAuthenticationComponent
    {
        private readonly IPortalUserRepository _portalUserRepository;

        public AuthenticationComponent(IPortalUserRepository portalUserRepository)
        {
            _portalUserRepository = portalUserRepository;
        }

        public string Authenticate (string userName, string passWord)
        {
            return string.Empty;
        }
    }
}
