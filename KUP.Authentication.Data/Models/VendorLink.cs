using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class VendorLink
    {
        public int VendorLinkId { get; set; }
        public int VendorId { get; set; }
        public int VendorEncryptionTypeId { get; set; }
        public string Href { get; set; }
        public string LinkCode { get; set; }
        public string LinkText { get; set; }
        public string VendorKey { get; set; }
        public string VendorPassword { get; set; }
        public int? CampusId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual VendorEncryptionType VendorEncryptionType { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
