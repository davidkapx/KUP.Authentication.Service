using KUP.Authentication.Data.Models;
using KUP.Authentication.Data.Repositories.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KUP.Authentication.Data.Repositories.Implementation
{
    public class PortalUserRepository : IPortalUserRepository
    {
        private readonly UniversityPortal_KVUContext _context;
        public PortalUserRepository(UniversityPortal_KVUContext context)
        {
            _context = context;
        }

        public async Task<PortalUser> GetPortalUserByUserName(string userName)
        {
            return await _context.PortalUser.Where(pu => pu.Username == userName).SingleOrDefaultAsync();
        }

        public async Task<PortalUserMapping> GetPortalUserStudentIDMapping(int portalUserId)
        {
            return await _context.PortalUserMapping.Where(pum => pum.PortalUserId == portalUserId && pum.UserMappingTypeId == 1).FirstOrDefaultAsync();
        }

        public async Task<PortalUserMapping> GetPortalUserInstructorIDMapping(int portalUserId)
        {
            return await _context.PortalUserMapping.Where(pum => pum.PortalUserId == portalUserId && pum.UserMappingTypeId == 2).FirstOrDefaultAsync();
        }
    }
}
