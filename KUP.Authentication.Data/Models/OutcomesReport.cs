using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class OutcomesReport
    {
        public int OutcomesReportId { get; set; }
        public int SyStudentId { get; set; }
        public string OutcomeCode { get; set; }
        public string OutcomeDescription { get; set; }
        public int? CountStrength { get; set; }
        public decimal? SumStrength { get; set; }
        public decimal? AverageScore { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
