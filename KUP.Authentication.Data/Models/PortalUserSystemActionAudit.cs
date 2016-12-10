using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserSystemActionAudit
    {
        public int PortalUserSystemActionAuditId { get; set; }
        public string Username { get; set; }
        public int? PortalUserId { get; set; }
        public int? StudentId { get; set; }
        public string Action { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifyBy { get; set; }
        public DateTime DateModified { get; set; }

        public virtual PortalUser PortalUser { get; set; }
    }
}
