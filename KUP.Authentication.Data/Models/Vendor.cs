using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            VendorLink = new HashSet<VendorLink>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorCode { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<VendorLink> VendorLink { get; set; }
    }
}
