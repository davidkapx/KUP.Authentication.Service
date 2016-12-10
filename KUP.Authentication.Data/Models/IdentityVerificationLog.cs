using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class IdentityVerificationLog
    {
        public int IdentityVerificationLogId { get; set; }
        public string Username { get; set; }
        public int? IStudentId { get; set; }
        public string ActivityType { get; set; }
        public bool IsSuccessful { get; set; }
        public string Ipaddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Details { get; set; }
        public string SessionId { get; set; }
    }
}
