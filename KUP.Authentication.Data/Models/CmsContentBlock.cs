using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsContentBlock
    {
        public CmsContentBlock()
        {
            CmsContentBlockAudience = new HashSet<CmsContentBlockAudience>();
            CmsContentScheduleEntryVersion = new HashSet<CmsContentScheduleEntryVersion>();
        }

        public int ContentBlockId { get; set; }
        public string ContentName { get; set; }
        public int TargetContentAreaFileId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentBlockAudience> CmsContentBlockAudience { get; set; }
        public virtual ICollection<CmsContentScheduleEntryVersion> CmsContentScheduleEntryVersion { get; set; }
    }
}
