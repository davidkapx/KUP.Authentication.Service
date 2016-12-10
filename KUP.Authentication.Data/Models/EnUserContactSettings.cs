using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnUserContactSettings
    {
        public int UserContactSettingsId { get; set; }
        public int PortalUserId { get; set; }
        public int CommunicationEndpointId { get; set; }
        public string SiscontactInfoType { get; set; }
        public int? SmsproviderId { get; set; }
        public bool IsEnabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual EnCommunicationEndpoint CommunicationEndpoint { get; set; }
        public virtual PortalUser PortalUser { get; set; }
        public virtual EnSmsprovider Smsprovider { get; set; }
    }
}
