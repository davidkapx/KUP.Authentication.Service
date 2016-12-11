using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KUP.Authentication.Business.Models.Enums;

namespace KUP.Authentication.Business.Models
{
    public class PortalUser
    {
        public AuthenticationType AuthenticationType { get; set; }
        public PasswordFormat PasswordFormat { get; set; }
        public string ADDomainName { get; set; }
        public string ADUserName { get; set; }
        public int PortalUserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool RequirePasswordChange { get; set; }
        public bool IsLocked { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastLockoutDate { get; set; }
        public List<Email> EmailAddresses { get; set; }
        public DateTime? PasswordChangeDate { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
    }
}
