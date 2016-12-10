using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ECollegeProgramVersionHomeroom
    {
        public int ECollegeProgramVersionHomeroomId { get; set; }
        public int ProgramVersionId { get; set; }
        public int ECollegeRoleId { get; set; }
        public string ECollegeCourseCallNumber { get; set; }
        public string ResourceUrlname { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
