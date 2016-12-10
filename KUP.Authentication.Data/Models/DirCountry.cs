using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirCountry
    {
        public DirCountry()
        {
            DirEducationInstitution = new HashSet<DirEducationInstitution>();
            DirStateProvince = new HashSet<DirStateProvince>();
            DirUserProfile = new HashSet<DirUserProfile>();
        }

        public short DirCountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DirEducationInstitution> DirEducationInstitution { get; set; }
        public virtual ICollection<DirStateProvince> DirStateProvince { get; set; }
        public virtual ICollection<DirUserProfile> DirUserProfile { get; set; }
    }
}
