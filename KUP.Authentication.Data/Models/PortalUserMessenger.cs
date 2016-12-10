using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserMessenger
    {
        public int PortalUserMessengerId { get; set; }
        public int? PortalUserId { get; set; }
        public string ContactId { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool? IsSignedIn { get; set; }
        public string ConsentAuthenticationToken { get; set; }
        public string DelegatedAuthenticationToken { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
