using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsContentScheduleEntry
    {
        public CmsContentScheduleEntry()
        {
            CmsContentScheduleEntryVersion = new HashSet<CmsContentScheduleEntryVersion>();
            CmswfContentScheduleEntryVersionApprovalState = new HashSet<CmswfContentScheduleEntryVersionApprovalState>();
        }

        public int ContentScheduleEntryId { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedContentScheduleEntryVersionId { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentScheduleEntryVersion> CmsContentScheduleEntryVersion { get; set; }
        public virtual ICollection<CmswfContentScheduleEntryVersionApprovalState> CmswfContentScheduleEntryVersionApprovalState { get; set; }
        public virtual CmsContentScheduleEntryVersion ApprovedContentScheduleEntryVersion { get; set; }
    }
}
