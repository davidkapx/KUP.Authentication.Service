using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class SystemCheckUserStatus
    {
        public int SystemCheckUserStatusId { get; set; }
        public int SystemCheckComponentTypeId { get; set; }
        public int PortalUserId { get; set; }
        public DateTime TestedDateTime { get; set; }
        public bool HasTestPassed { get; set; }
        public string ComponentDetails { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual PortalUser PortalUser { get; set; }
        public virtual SystemCheckComponentType SystemCheckComponentType { get; set; }
    }
}
