using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserAttribute
    {
        public int PortalUserAttributeId { get; set; }
        public int PortalUserId { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PortalUser PortalUser { get; set; }
    }
}
