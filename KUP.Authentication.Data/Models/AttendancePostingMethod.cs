using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class AttendancePostingMethod
    {
        public int AttendancePostingMethodId { get; set; }
        public int AttendancePostingMethodTypeId { get; set; }
        public int CourseTypeId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual AttendancePostingMethodType AttendancePostingMethodType { get; set; }
    }
}
