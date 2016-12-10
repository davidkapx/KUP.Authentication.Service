using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class AccountProvisioningProgramVersion
    {
        public int AccountProvisioningProgramVersionId { get; set; }
        public int ProgramVersionId { get; set; }
        public bool IsOnline { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
