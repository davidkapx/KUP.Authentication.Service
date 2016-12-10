using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirUserAffiliation
    {
        public int DirUserAffiliationId { get; set; }
        public int DirAffiliationId { get; set; }
        public int PortalUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsActive { get; set; }

        public virtual DirAffiliation DirAffiliation { get; set; }
        public virtual DirUserProfile PortalUser { get; set; }
    }
}
