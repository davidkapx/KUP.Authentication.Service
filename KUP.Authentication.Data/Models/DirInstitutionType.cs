using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirInstitutionType
    {
        public DirInstitutionType()
        {
            DirEducationInstitution = new HashSet<DirEducationInstitution>();
        }

        public byte DirInstitutionTypeId { get; set; }
        public string InstitutionTypeName { get; set; }

        public virtual ICollection<DirEducationInstitution> DirEducationInstitution { get; set; }
    }
}
