using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnUserEventSubscription
    {
        public int UserEventSubscriptionId { get; set; }
        public Guid EventId { get; set; }
        public int PortalUserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual PortalUser PortalUser { get; set; }
    }
}
