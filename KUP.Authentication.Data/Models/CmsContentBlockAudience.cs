using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsContentBlockAudience
    {
        public CmsContentBlockAudience()
        {
            CmsContentBlockAudienceCultureXhtml = new HashSet<CmsContentBlockAudienceCultureXhtml>();
        }

        public int ContentBlockAudienceId { get; set; }
        public int ContentBlockId { get; set; }
        public string AudienceName { get; set; }
        public bool IsUserControl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentBlockAudienceCultureXhtml> CmsContentBlockAudienceCultureXhtml { get; set; }
        public virtual CmsContentBlock ContentBlock { get; set; }
    }
}
