using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class OutcomesReportV1
    {
        public int OutcomesReportId { get; set; }
        public int? SyStudentId { get; set; }
        public string PoutcomeHeadline { get; set; }
        public string ProgramOutcomeCode { get; set; }
        public string ProgramOutcomeDescription { get; set; }
        public string CourseOutcomeCode { get; set; }
        public string CourseOutcomeDescription { get; set; }
        public decimal? CourseOutcomeScore { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
