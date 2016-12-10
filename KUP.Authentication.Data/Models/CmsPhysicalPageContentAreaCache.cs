using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsPhysicalPageContentAreaCache
    {
        public int PageContentAreaApprovedCacheId { get; set; }
        public int PageId { get; set; }
        public int ContentAreaFileId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual VfsFile ContentAreaFile { get; set; }
        public virtual CmsPage Page { get; set; }
    }
}
