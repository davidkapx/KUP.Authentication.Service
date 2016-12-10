using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class VfsFolder
    {
        public VfsFolder()
        {
            VfsFile = new HashSet<VfsFile>();
            VfsFolderAcl = new HashSet<VfsFolderAcl>();
            VfsFolderMetadata = new HashSet<VfsFolderMetadata>();
        }

        public int FolderId { get; set; }
        public string FolderName { get; set; }
        public int? ParentFolderId { get; set; }
        public bool InheritPermissions { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<VfsFile> VfsFile { get; set; }
        public virtual ICollection<VfsFolderAcl> VfsFolderAcl { get; set; }
        public virtual ICollection<VfsFolderMetadata> VfsFolderMetadata { get; set; }
        public virtual VfsFolder ParentFolder { get; set; }
        public virtual ICollection<VfsFolder> InverseParentFolder { get; set; }
    }
}
