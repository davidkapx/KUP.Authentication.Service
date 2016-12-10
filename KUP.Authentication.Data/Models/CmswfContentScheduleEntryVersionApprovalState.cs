using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmswfContentScheduleEntryVersionApprovalState
    {
        public int ContentScheduleEntryVersionApprovalStateId { get; set; }
        public int ContentScheduleEntryId { get; set; }
        public int ProjectId { get; set; }
        public string StateName { get; set; }
        public DateTime StateEntryTime { get; set; }
        public string StateChangedBy { get; set; }
        public string StateChangeNotes { get; set; }
        public byte[] AccurateEntryOrder { get; set; }

        public virtual CmsContentScheduleEntry ContentScheduleEntry { get; set; }
        public virtual CmsProject Project { get; set; }
    }
}
