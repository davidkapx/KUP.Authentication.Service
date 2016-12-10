using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsPageScheduleEntry
    {
        public CmsPageScheduleEntry()
        {
            CmsPageScheduleEntryVersion = new HashSet<CmsPageScheduleEntryVersion>();
            CmswfPageScheduleEntryVersionApprovalState = new HashSet<CmswfPageScheduleEntryVersionApprovalState>();
        }

        public int PageScheduleEntryId { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedPageScheduleEntryVersionId { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsPageScheduleEntryVersion> CmsPageScheduleEntryVersion { get; set; }
        public virtual ICollection<CmswfPageScheduleEntryVersionApprovalState> CmswfPageScheduleEntryVersionApprovalState { get; set; }
        public virtual CmsPageScheduleEntryVersion ApprovedPageScheduleEntryVersion { get; set; }
    }
}
