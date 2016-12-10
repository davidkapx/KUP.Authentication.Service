using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class AdAuthenticationDomain
    {
        public AdAuthenticationDomain()
        {
            PortalUser = new HashSet<PortalUser>();
        }

        public int AdAuthenticationDomainId { get; set; }
        public string ConnectionString { get; set; }
        public string DomainName { get; set; }
        public string DisplayDomainName { get; set; }
        public string DomainControllerList { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<PortalUser> PortalUser { get; set; }
    }
}
