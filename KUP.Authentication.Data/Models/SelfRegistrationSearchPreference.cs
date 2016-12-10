using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class SelfRegistrationSearchPreference
    {
        public int SelfRegistrationSearchPreferenceId { get; set; }
        public int TermId { get; set; }
        public string SelectedDays { get; set; }
        public string SelectedTimes { get; set; }
        public int StudentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
