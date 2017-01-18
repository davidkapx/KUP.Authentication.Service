using KUP.Authentication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Data.Repositories.Definition
{
    public interface IPortalUserRepository
    {
        PortalUser GetPortalUserByUserName(string userName);
        PortalUserMapping GetPortalUserStudentIDMapping(int portalUserId);
        PortalUserMapping GetPortalUserInstructorIDMapping(int portalUserId);
    }
}
