using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirUserContactRequest
    {
        public int DirUserContactRequestId { get; set; }
        public int PortalUserIdInviter { get; set; }
        public int PortalUserIdContact { get; set; }
        public byte DirContactRequestStatusId { get; set; }
        public bool? IsPermanentlyBlocked { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual DirContactRequestStatus DirContactRequestStatus { get; set; }
        public virtual DirUserProfile PortalUserIdInviterNavigation { get; set; }
    }
}
