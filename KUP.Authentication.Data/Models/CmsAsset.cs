using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsAsset
    {
        public int AssetId { get; set; }
        public int VfsFileId { get; set; }
        public string Mimetype { get; set; }
        public long Size { get; set; }
        public byte[] Data { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual VfsFile VfsFile { get; set; }
    }
}
