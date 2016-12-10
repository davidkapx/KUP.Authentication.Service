using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalNotification
    {
        public int PortalNotificationId { get; set; }
        public int PortalUserId { get; set; }
        public bool HasBeenRead { get; set; }
        public DateTime DateReceived { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual PortalUser PortalUser { get; set; }
    }
}
