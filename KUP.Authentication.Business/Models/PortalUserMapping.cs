using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Business.Models
{
    public class PortalUserMapping
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
    }
}
