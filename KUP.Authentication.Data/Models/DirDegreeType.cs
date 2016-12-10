using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirDegreeType
    {
        public DirDegreeType()
        {
            DirEducationHistory = new HashSet<DirEducationHistory>();
        }

        public int DirDegreeTypeId { get; set; }
        public string DegreeName { get; set; }
        public string DegreeDescription { get; set; }

        public virtual ICollection<DirEducationHistory> DirEducationHistory { get; set; }
    }
}
