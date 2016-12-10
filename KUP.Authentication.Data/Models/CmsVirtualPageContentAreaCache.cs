using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsVirtualPageContentAreaCache
    {
        public int PageContentAreaProjectCacheId { get; set; }
        public int VirtualPageVersionId { get; set; }
        public int ContentAreaFileId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual VfsFile ContentAreaFile { get; set; }
        public virtual CmsVirtualPageVersion VirtualPageVersion { get; set; }
    }
}
