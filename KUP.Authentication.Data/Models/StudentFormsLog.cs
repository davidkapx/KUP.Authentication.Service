using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class StudentFormsLog
    {
        public int StudentFormsLogId { get; set; }
        public string RequestType { get; set; }
        public int TermId { get; set; }
        public int CourseId { get; set; }
        public int SyStudentId { get; set; }
        public int SyStaffId { get; set; }
        public decimal OverAllGradePoint { get; set; }
        public string StudentRequestDetails { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
