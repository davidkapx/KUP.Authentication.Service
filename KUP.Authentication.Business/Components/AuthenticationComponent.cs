using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KUP.Authentication.Data;

namespace KUP.Authentication.Business.Components
{
    public class AuthenticationComponent
    {
        public string  Authenticate()
        {
            using (var context = new KUP.Authentication.Data.Models.UniversityPortal_KVUContext())
            {
                return context.PortalUser.Where(e => e.Username == "Ralph").Single().Username;
            }
        }
    }
}
