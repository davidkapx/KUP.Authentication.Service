using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsPage
    {
        public CmsPage()
        {
            CmsContentScheduleEntryVersion = new HashSet<CmsContentScheduleEntryVersion>();
            CmsPageScheduleEntryVersion = new HashSet<CmsPageScheduleEntryVersion>();
            CmsPhysicalPageContentAreaCache = new HashSet<CmsPhysicalPageContentAreaCache>();
            CmsSiteMapNodeVersion = new HashSet<CmsSiteMapNodeVersion>();
            CmsVirtualPage = new HashSet<CmsVirtualPage>();
        }

        public int PageId { get; set; }
        public int VfsFileId { get; set; }
        public bool IsVirtualPage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentScheduleEntryVersion> CmsContentScheduleEntryVersion { get; set; }
        public virtual ICollection<CmsPageScheduleEntryVersion> CmsPageScheduleEntryVersion { get; set; }
        public virtual ICollection<CmsPhysicalPageContentAreaCache> CmsPhysicalPageContentAreaCache { get; set; }
        public virtual ICollection<CmsSiteMapNodeVersion> CmsSiteMapNodeVersion { get; set; }
        public virtual ICollection<CmsVirtualPage> CmsVirtualPage { get; set; }
        public virtual VfsFile VfsFile { get; set; }
    }
}
