using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class StudentGradeRequestReasonType
    {
        public StudentGradeRequestReasonType()
        {
            StudentGradeRequestReason = new HashSet<StudentGradeRequestReason>();
        }

        public int StudentGradeRequestReasonTypeId { get; set; }
        public string ReasonTypeDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<StudentGradeRequestReason> StudentGradeRequestReason { get; set; }
    }
}
