using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmxActivityFromEventConfig
    {
        public Guid EnEvent { get; set; }
        public int ActivityTemplateId { get; set; }
        public int ActivityEventTypeId { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual EnEvent EnEventNavigation { get; set; }
    }
}
