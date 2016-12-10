using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsSiteMapNodeVersionMetadata
    {
        public int SiteMapNodeVersionMetadataId { get; set; }
        public int SiteMapNodeVersionId { get; set; }
        public int CultureCodeId { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CmsCultureCode CultureCode { get; set; }
        public virtual CmsSiteMapNodeVersion SiteMapNodeVersion { get; set; }
    }
}
