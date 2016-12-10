using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsEditSession
    {
        public CmsEditSession()
        {
            CmsContentBlockAudienceCultureXhtmlversion = new HashSet<CmsContentBlockAudienceCultureXhtmlversion>();
            CmsVirtualPageVersion = new HashSet<CmsVirtualPageVersion>();
        }

        public int EditSessionId { get; set; }
        public string Username { get; set; }
        public DateTime? WriteLocksExpiration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CmsContentBlockAudienceCultureXhtmlversion> CmsContentBlockAudienceCultureXhtmlversion { get; set; }
        public virtual ICollection<CmsVirtualPageVersion> CmsVirtualPageVersion { get; set; }
    }
}
