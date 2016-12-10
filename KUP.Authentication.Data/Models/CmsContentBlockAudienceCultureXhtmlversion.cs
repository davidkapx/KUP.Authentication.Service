using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsContentBlockAudienceCultureXhtmlversion
    {
        public CmsContentBlockAudienceCultureXhtmlversion()
        {
            CmsContentBlockAudienceCultureXhtml = new HashSet<CmsContentBlockAudienceCultureXhtml>();
        }

        public int ContentBlockAudienceCultureXhtmlversionId { get; set; }
        public int ContentBlockAudienceCultureXhtmlid { get; set; }
        public int ProjectId { get; set; }
        public string Xhtmlfragment { get; set; }
        public bool IsWriteLocked { get; set; }
        public int? WriteLockedEditSessionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentBlockAudienceCultureXhtml> CmsContentBlockAudienceCultureXhtml { get; set; }
        public virtual CmsContentBlockAudienceCultureXhtml ContentBlockAudienceCultureXhtml { get; set; }
        public virtual CmsProject Project { get; set; }
        public virtual CmsEditSession WriteLockedEditSession { get; set; }
    }
}
