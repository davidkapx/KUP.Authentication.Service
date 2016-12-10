using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnCommunicationTracking
    {
        public int CommunicationTrackingId { get; set; }
        public Guid? EventId { get; set; }
        public int PortalUserId { get; set; }
        public int CommunicationEndpointId { get; set; }
        public Guid CorrelationId { get; set; }
        public string Recipient { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual EnCommunicationEndpoint CommunicationEndpoint { get; set; }
    }
}
