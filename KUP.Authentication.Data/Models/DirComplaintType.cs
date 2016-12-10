using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirComplaintType
    {
        public DirComplaintType()
        {
            DirUserComplaint = new HashSet<DirUserComplaint>();
        }

        public int DirComplaintTypeId { get; set; }
        public string ComplaintTypeName { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DirUserComplaint> DirUserComplaint { get; set; }
    }
}
