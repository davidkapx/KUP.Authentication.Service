using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsPageScheduleEntryVersion
    {
        public CmsPageScheduleEntryVersion()
        {
            CmsPageScheduleEntry = new HashSet<CmsPageScheduleEntry>();
        }

        public int PageScheduleEntryVersionId { get; set; }
        public int PageScheduleEntryId { get; set; }
        public int ProjectId { get; set; }
        public int PageId { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime? PublishEndDate { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsPageScheduleEntry> CmsPageScheduleEntry { get; set; }
        public virtual CmsPage Page { get; set; }
        public virtual CmsPageScheduleEntry PageScheduleEntry { get; set; }
        public virtual CmsProject Project { get; set; }
    }
}
