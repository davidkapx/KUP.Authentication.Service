using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsContentScheduleEntryVersion
    {
        public CmsContentScheduleEntryVersion()
        {
            CmsContentScheduleEntry = new HashSet<CmsContentScheduleEntry>();
        }

        public int ContentScheduleEntryVersionId { get; set; }
        public int ContentScheduleEntryId { get; set; }
        public int ProjectId { get; set; }
        public int PageId { get; set; }
        public int ContentBlockId { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime? PublishEndDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentScheduleEntry> CmsContentScheduleEntry { get; set; }
        public virtual CmsContentBlock ContentBlock { get; set; }
        public virtual CmsContentScheduleEntry ContentScheduleEntry { get; set; }
        public virtual CmsPage Page { get; set; }
        public virtual CmsProject Project { get; set; }
    }
}
