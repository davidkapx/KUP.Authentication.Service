using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class AuthenticationType
    {
        public AuthenticationType()
        {
            PortalUser = new HashSet<PortalUser>();
        }

        public short AuthenticationTypeId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<PortalUser> PortalUser { get; set; }
    }
}
