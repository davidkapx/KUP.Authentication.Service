using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirEducationInstitution
    {
        public DirEducationInstitution()
        {
            DirEducationHistory = new HashSet<DirEducationHistory>();
        }

        public int DirEducationInstitutionId { get; set; }
        public string Name { get; set; }
        public byte DirInstitutionTypeId { get; set; }
        public short? DirCountryId { get; set; }
        public int? DirStateProvinceId { get; set; }
        public bool UserDefined { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }

        public virtual ICollection<DirEducationHistory> DirEducationHistory { get; set; }
        public virtual DirCountry DirCountry { get; set; }
        public virtual DirInstitutionType DirInstitutionType { get; set; }
        public virtual DirStateProvince DirStateProvince { get; set; }
    }
}
