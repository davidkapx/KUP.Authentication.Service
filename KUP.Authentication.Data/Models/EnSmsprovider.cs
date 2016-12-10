using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnSmsprovider
    {
        public EnSmsprovider()
        {
            EnUserContactSettings = new HashSet<EnUserContactSettings>();
        }

        public int SmsproviderId { get; set; }
        public string ProviderName { get; set; }
        public string EmailFormat { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<EnUserContactSettings> EnUserContactSettings { get; set; }
    }
}
