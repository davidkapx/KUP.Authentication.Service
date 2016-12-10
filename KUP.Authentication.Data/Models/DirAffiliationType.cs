using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirAffiliationType
    {
        public DirAffiliationType()
        {
            DirAffiliation = new HashSet<DirAffiliation>();
        }

        public int DirAffiliationTypeId { get; set; }
        public string AffiliationTypeName { get; set; }
        public string AffiliationTypeDescription { get; set; }

        public virtual ICollection<DirAffiliation> DirAffiliation { get; set; }
    }
}
