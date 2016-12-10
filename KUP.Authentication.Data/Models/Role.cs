using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            PortalUserRole = new HashSet<PortalUserRole>();
            RolePermission = new HashSet<RolePermission>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
        public bool IsSystemRole { get; set; }

        public virtual ICollection<PortalUserRole> PortalUserRole { get; set; }
        public virtual ICollection<RolePermission> RolePermission { get; set; }
    }
}
