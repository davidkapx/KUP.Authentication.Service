using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsCultureCode
    {
        public CmsCultureCode()
        {
            CmsContentBlockAudienceCultureXhtml = new HashSet<CmsContentBlockAudienceCultureXhtml>();
            CmsSiteMapNodeVersionMetadata = new HashSet<CmsSiteMapNodeVersionMetadata>();
            CmsVirtualPage = new HashSet<CmsVirtualPage>();
        }

        public int CultureCodeId { get; set; }
        public string CultureCode { get; set; }
        public string CultureName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentBlockAudienceCultureXhtml> CmsContentBlockAudienceCultureXhtml { get; set; }
        public virtual ICollection<CmsSiteMapNodeVersionMetadata> CmsSiteMapNodeVersionMetadata { get; set; }
        public virtual ICollection<CmsVirtualPage> CmsVirtualPage { get; set; }
    }
}
