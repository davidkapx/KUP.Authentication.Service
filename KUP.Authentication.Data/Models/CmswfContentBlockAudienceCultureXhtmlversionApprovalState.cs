using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmswfContentBlockAudienceCultureXhtmlversionApprovalState
    {
        public int ContentBlockAudienceCultureXhtmlversionApprovalStateId { get; set; }
        public int ContentBlockAudienceCultureXhtmlid { get; set; }
        public int ProjectId { get; set; }
        public string StateName { get; set; }
        public DateTime StateEntryTime { get; set; }
        public string StateChangedBy { get; set; }
        public string StateChangeNotes { get; set; }
        public byte[] AccurateEntryOrder { get; set; }

        public virtual CmsContentBlockAudienceCultureXhtml ContentBlockAudienceCultureXhtml { get; set; }
        public virtual CmsProject Project { get; set; }
    }
}
