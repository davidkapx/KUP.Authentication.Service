using KUP.Authentication.Data.Models;
using KUP.Authentication.Data.Repositories.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Data.Repositories.Implementation
{
    public class PortalUserRepository : IPortalUserRepository
    {
        private readonly UniversityPortal_KVUContext _context;
        public PortalUserRepository(UniversityPortal_KVUContext context)
        {
            _context = context;
        }

        public PortalUser GetPortalUserByUserName(string userName)
        {
            return _context.PortalUser.Where(pu => pu.Username == userName).SingleOrDefault();
        }

        public PortalUserMapping GetPortalUserStudentIDMapping(int portalUserId)
        {
            return _context.PortalUserMapping.Where(pum => pum.PortalUserId == portalUserId && pum.UserMappingTypeId == 1).FirstOrDefault();
        }

        public PortalUserMapping GetPortalUserInstructorIDMapping(int portalUserId)
        {
            return _context.PortalUserMapping.Where(pum => pum.PortalUserId == portalUserId && pum.UserMappingTypeId == 2).FirstOrDefault();
        }
    }
}
