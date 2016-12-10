using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirAffiliation
    {
        public DirAffiliation()
        {
            DirUserAffiliation = new HashSet<DirUserAffiliation>();
        }

        public int DirAffiliationId { get; set; }
        public string AffiliationName { get; set; }
        public string AffiliationDescription { get; set; }
        public int DirAffiliationTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DirUserAffiliation> DirUserAffiliation { get; set; }
        public virtual DirAffiliationType DirAffiliationType { get; set; }
    }
}
