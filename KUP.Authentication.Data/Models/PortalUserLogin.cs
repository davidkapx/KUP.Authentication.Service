using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserLogin
    {
        public int PortalUserLoginId { get; set; }
        public string Username { get; set; }
        public int? PortalUserId { get; set; }
        public int? StudentId { get; set; }
        public string Ipaddress { get; set; }
        public string AuthenticationResult { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PortalUser PortalUser { get; set; }
    }
}
