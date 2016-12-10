using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class VfsFolderMetadata
    {
        public int FolderMetadataId { get; set; }
        public int FolderId { get; set; }
        public string MetadataKey { get; set; }
        public string MetadataValue { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual VfsFolder Folder { get; set; }
    }
}
