using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserMapping
    {
        public int PortalUserMappingId { get; set; }
        public int PortalUserId { get; set; }
        public int CampusId { get; set; }
        public int UserMappingTypeId { get; set; }
        public string MappedId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual PortalUser PortalUser { get; set; }
        public virtual UserMappingType UserMappingType { get; set; }
    }
}
