using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ECollegeHomeroomAuditLog
    {
        public int ECollegeHomeroomAuditLogId { get; set; }
        public string Type { get; set; }
        public int SchoolId { get; set; }
        public int ProgramId { get; set; }
        public int ProgramVersionId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] Ts { get; set; }
    }
}
