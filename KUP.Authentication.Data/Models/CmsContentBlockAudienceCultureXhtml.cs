using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsContentBlockAudienceCultureXhtml
    {
        public CmsContentBlockAudienceCultureXhtml()
        {
            CmsContentBlockAudienceCultureXhtmlversion = new HashSet<CmsContentBlockAudienceCultureXhtmlversion>();
            CmswfContentBlockAudienceCultureXhtmlversionApprovalState = new HashSet<CmswfContentBlockAudienceCultureXhtmlversionApprovalState>();
        }

        public int ContentBlockAudienceCultureXhtmlid { get; set; }
        public int ContentBlockAudienceId { get; set; }
        public int CultureCodeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedContentBlockAudienceCultureXhtmlversionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentBlockAudienceCultureXhtmlversion> CmsContentBlockAudienceCultureXhtmlversion { get; set; }
        public virtual ICollection<CmswfContentBlockAudienceCultureXhtmlversionApprovalState> CmswfContentBlockAudienceCultureXhtmlversionApprovalState { get; set; }
        public virtual CmsContentBlockAudienceCultureXhtmlversion ApprovedContentBlockAudienceCultureXhtmlversion { get; set; }
        public virtual CmsContentBlockAudience ContentBlockAudience { get; set; }
        public virtual CmsCultureCode CultureCode { get; set; }
    }
}
