using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirEducationHistory
    {
        public int DirEducationHistoryId { get; set; }
        public int PortalUserId { get; set; }
        public int DirEducationInstitutionId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int DirDegreeTypeId { get; set; }
        public string Specialty { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual DirDegreeType DirDegreeType { get; set; }
        public virtual DirEducationInstitution DirEducationInstitution { get; set; }
        public virtual DirUserProfile PortalUser { get; set; }
    }
}
