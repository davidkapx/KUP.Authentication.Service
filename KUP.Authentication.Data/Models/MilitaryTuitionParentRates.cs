using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class MilitaryTuitionParentRates
    {
        public int MilitaryTuitionParentRatesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TuitionRate { get; set; }
        public decimal TuitionDiscountRate { get; set; }
        public decimal TuitionDiscountPercent { get; set; }
        public string TuitionDiscountType { get; set; }
        public decimal ProgramFee { get; set; }
        public decimal TechnologyFee { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifyBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
