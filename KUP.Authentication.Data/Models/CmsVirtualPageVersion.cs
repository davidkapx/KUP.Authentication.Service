using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsVirtualPageVersion
    {
        public CmsVirtualPageVersion()
        {
            CmsVirtualPage = new HashSet<CmsVirtualPage>();
            CmsVirtualPageContentAreaCache = new HashSet<CmsVirtualPageContentAreaCache>();
        }

        public int VirtualPageVersionId { get; set; }
        public int VirtualPageId { get; set; }
        public int ProjectId { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string MasterPagePath { get; set; }
        public string LayoutXhtml { get; set; }
        public bool IsWriteLocked { get; set; }
        public int? WriteLockedEditSessionId { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsVirtualPage> CmsVirtualPage { get; set; }
        public virtual ICollection<CmsVirtualPageContentAreaCache> CmsVirtualPageContentAreaCache { get; set; }
        public virtual CmsProject Project { get; set; }
        public virtual CmsVirtualPage VirtualPage { get; set; }
        public virtual CmsEditSession WriteLockedEditSession { get; set; }
    }
}
