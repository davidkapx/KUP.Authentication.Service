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
    }
}
