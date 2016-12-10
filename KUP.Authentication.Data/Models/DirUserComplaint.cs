using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirUserComplaint
    {
        public int DirUserComplaintId { get; set; }
        public int PortalUserIdDefendant { get; set; }
        public int PortalUserIdPlantiff { get; set; }
        public int DirComplaintTypeId { get; set; }
        public string Comment { get; set; }
        public string ComplaintLink { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual DirComplaintType DirComplaintType { get; set; }
        public virtual DirUserProfile PortalUserIdDefendantNavigation { get; set; }
    }
}
