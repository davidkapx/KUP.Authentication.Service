using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class SelfRegistrationConfiguration
    {
        public int SelfRegistrationConfigurationId { get; set; }
        public bool Active { get; set; }
        public int? ProgramId { get; set; }
        public int? StudentTypeId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
