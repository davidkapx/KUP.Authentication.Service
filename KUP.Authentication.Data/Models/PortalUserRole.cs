using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserRole
    {
        public int PortalUserRoleId { get; set; }
        public int PortalUserId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual PortalUser PortalUser { get; set; }
        public virtual Role Role { get; set; }
    }
}
