using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class StudentPlacementExam
    {
        public int StudentPlacementExamId { get; set; }
        public int PlacementExamId { get; set; }
        public int StudentId { get; set; }
        public int? Score { get; set; }
        public bool? Passed { get; set; }
        public bool? Retake { get; set; }
        public bool Processed { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
