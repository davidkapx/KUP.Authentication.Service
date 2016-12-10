using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class VfsFile
    {
        public VfsFile()
        {
            CmsAsset = new HashSet<CmsAsset>();
            CmsPage = new HashSet<CmsPage>();
            CmsPhysicalPageContentAreaCache = new HashSet<CmsPhysicalPageContentAreaCache>();
            CmsTemplatePage = new HashSet<CmsTemplatePage>();
            CmsVirtualPageContentAreaCache = new HashSet<CmsVirtualPageContentAreaCache>();
            VfsFileAcl = new HashSet<VfsFileAcl>();
            VfsFileMetadata = new HashSet<VfsFileMetadata>();
        }

        public int FileId { get; set; }
        public string FileName { get; set; }
        public int FolderId { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsAsset> CmsAsset { get; set; }
        public virtual ICollection<CmsPage> CmsPage { get; set; }
        public virtual ICollection<CmsPhysicalPageContentAreaCache> CmsPhysicalPageContentAreaCache { get; set; }
        public virtual ICollection<CmsTemplatePage> CmsTemplatePage { get; set; }
        public virtual ICollection<CmsVirtualPageContentAreaCache> CmsVirtualPageContentAreaCache { get; set; }
        public virtual ICollection<VfsFileAcl> VfsFileAcl { get; set; }
        public virtual ICollection<VfsFileMetadata> VfsFileMetadata { get; set; }
        public virtual VfsFolder Folder { get; set; }
    }
}
