using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class MilitaryTuitionRates
    {
        public int MilitaryTuitionRateId { get; set; }
        public int MilitaryStatusId { get; set; }
        public string MilitaryStatus { get; set; }
        public int GraduateLevel { get; set; }
        public int ProgramId { get; set; }
        public string ProgramCode { get; set; }
        public string ProgramName { get; set; }
        public int ProgramVersionId { get; set; }
        public string ProgramVersionCode { get; set; }
        public string ProgramVersionName { get; set; }
        public string CoursePrefix { get; set; }
        public decimal TuitionRate { get; set; }
        public decimal TuitionDiscountRate { get; set; }
        public decimal TuitionDiscountPercent { get; set; }
        public string TuitionDiscountType { get; set; }
        public decimal ProgramFee { get; set; }
        public decimal TechnologyFee { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public int? MilitaryTuitionParentRatesId { get; set; }
    }
}
