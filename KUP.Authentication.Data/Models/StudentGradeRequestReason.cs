using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class StudentGradeRequestReason
    {
        public StudentGradeRequestReason()
        {
            StudentGradeRequest = new HashSet<StudentGradeRequest>();
        }

        public int StudentGradeRequestReasonId { get; set; }
        public int StudentGradeRequestReasonTypeId { get; set; }
        public string ReasonDesc { get; set; }
        public string Createdby { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<StudentGradeRequest> StudentGradeRequest { get; set; }
        public virtual StudentGradeRequestReasonType StudentGradeRequestReasonType { get; set; }
    }
}
