using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnEventMessageTemplate
    {
        public int EventMessageTemplateId { get; set; }
        public Guid EventId { get; set; }
        public int CommunicationEndpointId { get; set; }
        public string TemplatesXml { get; set; }
        public bool IsRequired { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual EnCommunicationEndpoint CommunicationEndpoint { get; set; }
        public virtual EnEvent Event { get; set; }
    }
}
