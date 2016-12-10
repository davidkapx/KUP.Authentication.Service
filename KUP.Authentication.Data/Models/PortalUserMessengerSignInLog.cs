using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserMessengerSignInLog
    {
        public int MessengerSignInLog { get; set; }
        public int? PortalUserId { get; set; }
        public bool? IsSignIn { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual PortalUser PortalUser { get; set; }
    }
}
