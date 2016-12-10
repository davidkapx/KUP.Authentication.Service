using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class VfsFolderAcl
    {
        public int FolderAclid { get; set; }
        public int FolderId { get; set; }
        public string Rolename { get; set; }
        public bool AllowDenyPermission { get; set; }
        public int PermissionSet { get; set; }
        public int AppliesToType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual VfsFolder Folder { get; set; }
    }
}
