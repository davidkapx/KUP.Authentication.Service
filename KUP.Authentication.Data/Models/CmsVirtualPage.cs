using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsVirtualPage
    {
        public CmsVirtualPage()
        {
            CmsVirtualPageVersion = new HashSet<CmsVirtualPageVersion>();
            CmswfVirtualPageVersionApprovalState = new HashSet<CmswfVirtualPageVersionApprovalState>();
        }

        public int VirtualPageId { get; set; }
        public int PageId { get; set; }
        public int CultureCodeId { get; set; }
        public int? ApprovedVirtualPageVersionId { get; set; }
        public bool IsApproved { get; set; }
        public string LastApprovalActionUsername { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsVirtualPageVersion> CmsVirtualPageVersion { get; set; }
        public virtual ICollection<CmswfVirtualPageVersionApprovalState> CmswfVirtualPageVersionApprovalState { get; set; }
        public virtual CmsVirtualPageVersion ApprovedVirtualPageVersion { get; set; }
        public virtual CmsCultureCode CultureCode { get; set; }
        public virtual CmsPage Page { get; set; }
    }
}
