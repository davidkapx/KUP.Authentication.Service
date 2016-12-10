using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsSiteMapNode
    {
        public CmsSiteMapNode()
        {
            CmsSiteMapNodeVersion = new HashSet<CmsSiteMapNodeVersion>();
        }

        public int SiteMapNodeId { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedSiteMapNodeVersionId { get; set; }
        public string LastApprovalActionUsername { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsSiteMapNodeVersion> CmsSiteMapNodeVersion { get; set; }
        public virtual CmsSiteMapNodeVersion ApprovedSiteMapNodeVersion { get; set; }
    }
}
