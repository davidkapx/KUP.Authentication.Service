using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirStateProvince
    {
        public DirStateProvince()
        {
            DirEducationInstitution = new HashSet<DirEducationInstitution>();
            DirUserProfile = new HashSet<DirUserProfile>();
        }

        public int DirStateProvinceId { get; set; }
        public string StateProvinceName { get; set; }
        public string Abbreviation { get; set; }
        public short? DirCountryId { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DirEducationInstitution> DirEducationInstitution { get; set; }
        public virtual ICollection<DirUserProfile> DirUserProfile { get; set; }
        public virtual DirCountry DirCountry { get; set; }
    }
}
