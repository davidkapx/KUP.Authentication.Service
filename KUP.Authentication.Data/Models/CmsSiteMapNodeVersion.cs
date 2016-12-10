using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsSiteMapNodeVersion
    {
        public CmsSiteMapNodeVersion()
        {
            CmsSiteMapNode = new HashSet<CmsSiteMapNode>();
            CmsSiteMapNodeVersionMetadata = new HashSet<CmsSiteMapNodeVersionMetadata>();
        }

        public int SiteMapNodeVersionId { get; set; }
        public int SiteMapNodeId { get; set; }
        public int? ParentSiteMapNodeId { get; set; }
        public int ProjectId { get; set; }
        public bool IsManagedReference { get; set; }
        public string UnmanagedUrl { get; set; }
        public int? ManagedPageId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ParamId { get; set; }
        public int Ordinal { get; set; }
        public bool HideChildren { get; set; }
        public bool IsPopUp { get; set; }

        public virtual ICollection<CmsSiteMapNode> CmsSiteMapNode { get; set; }
        public virtual ICollection<CmsSiteMapNodeVersionMetadata> CmsSiteMapNodeVersionMetadata { get; set; }
        public virtual CmsPage ManagedPage { get; set; }
        public virtual CmsProject Project { get; set; }
        public virtual CmsSiteMapNode SiteMapNode { get; set; }
    }
}
