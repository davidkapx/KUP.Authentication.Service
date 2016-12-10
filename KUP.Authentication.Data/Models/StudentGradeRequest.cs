using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class StudentGradeRequest
    {
        public int StudentGradeRequestId { get; set; }
        public int AdTermId { get; set; }
        public int AdCourseId { get; set; }
        public int SyStaffId { get; set; }
        public int SyStudentId { get; set; }
        public decimal OverallGradePoint { get; set; }
        public int StudentGradeRequestReasonId { get; set; }
        public string StudentRequestDetails { get; set; }
        public string RequestType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual StudentGradeRequestReason StudentGradeRequestReason { get; set; }
    }
}
