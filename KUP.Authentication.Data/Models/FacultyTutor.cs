using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class FacultyTutor
    {
        public int FacultTutorId { get; set; }
        public int? FacultyId { get; set; }
        public int? TutorRole { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
