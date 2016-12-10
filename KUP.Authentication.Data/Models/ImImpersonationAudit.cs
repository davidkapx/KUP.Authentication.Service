using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ImImpersonationAudit
    {
        public int ImpersonationAuditId { get; set; }
        public int ImpersonatingPortalUserId { get; set; }
        public int ImpersonatedPortalUserId { get; set; }
        public bool IsIndirect { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
