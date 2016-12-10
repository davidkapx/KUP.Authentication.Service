using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnCommunicationEndpoint
    {
        public EnCommunicationEndpoint()
        {
            EnCommunicationTracking = new HashSet<EnCommunicationTracking>();
            EnEventMessageTemplate = new HashSet<EnEventMessageTemplate>();
            EnUserContactSettings = new HashSet<EnUserContactSettings>();
        }

        public int CommunicationEndpointId { get; set; }
        public string Name { get; set; }
        public string EndpointUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<EnCommunicationTracking> EnCommunicationTracking { get; set; }
        public virtual ICollection<EnEventMessageTemplate> EnEventMessageTemplate { get; set; }
        public virtual ICollection<EnUserContactSettings> EnUserContactSettings { get; set; }
    }
}
