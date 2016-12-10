using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsProject
    {
        public CmsProject()
        {
            CmsContentBlockAudienceCultureXhtmlversion = new HashSet<CmsContentBlockAudienceCultureXhtmlversion>();
            CmsContentScheduleEntryVersion = new HashSet<CmsContentScheduleEntryVersion>();
            CmsPageScheduleEntryVersion = new HashSet<CmsPageScheduleEntryVersion>();
            CmsSiteMapNodeVersion = new HashSet<CmsSiteMapNodeVersion>();
            CmsVirtualPageVersion = new HashSet<CmsVirtualPageVersion>();
            CmswfContentBlockAudienceCultureXhtmlversionApprovalState = new HashSet<CmswfContentBlockAudienceCultureXhtmlversionApprovalState>();
            CmswfContentScheduleEntryVersionApprovalState = new HashSet<CmswfContentScheduleEntryVersionApprovalState>();
            CmswfPageScheduleEntryVersionApprovalState = new HashSet<CmswfPageScheduleEntryVersionApprovalState>();
            CmswfVirtualPageVersionApprovalState = new HashSet<CmswfVirtualPageVersionApprovalState>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public bool IsApproved { get; set; }
        public string LastApprovalActionUsername { get; set; }
        public bool IsLocked { get; set; }
        public string LastLockActionUsername { get; set; }
        public string LastLockActionReason { get; set; }
        public short Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentBlockAudienceCultureXhtmlversion> CmsContentBlockAudienceCultureXhtmlversion { get; set; }
        public virtual ICollection<CmsContentScheduleEntryVersion> CmsContentScheduleEntryVersion { get; set; }
        public virtual ICollection<CmsPageScheduleEntryVersion> CmsPageScheduleEntryVersion { get; set; }
        public virtual ICollection<CmsSiteMapNodeVersion> CmsSiteMapNodeVersion { get; set; }
        public virtual ICollection<CmsVirtualPageVersion> CmsVirtualPageVersion { get; set; }
        public virtual ICollection<CmswfContentBlockAudienceCultureXhtmlversionApprovalState> CmswfContentBlockAudienceCultureXhtmlversionApprovalState { get; set; }
        public virtual ICollection<CmswfContentScheduleEntryVersionApprovalState> CmswfContentScheduleEntryVersionApprovalState { get; set; }
        public virtual ICollection<CmswfPageScheduleEntryVersionApprovalState> CmswfPageScheduleEntryVersionApprovalState { get; set; }
        public virtual ICollection<CmswfVirtualPageVersionApprovalState> CmswfVirtualPageVersionApprovalState { get; set; }
    }
}
