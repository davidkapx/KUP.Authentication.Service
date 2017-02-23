using KUP.Authentication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Data.Repositories.Definition
{
    public interface IPortalUserRepository
    {
        Task<PortalUser> GetPortalUserByUserName(string userName);
        Task<PortalUserMapping> GetPortalUserStudentIDMapping(int portalUserId);
        Task<PortalUserMapping> GetPortalUserInstructorIDMapping(int portalUserId);
    }
}
