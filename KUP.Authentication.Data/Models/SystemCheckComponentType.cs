using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class SystemCheckComponentType
    {
        public SystemCheckComponentType()
        {
            SystemCheckUserStatus = new HashSet<SystemCheckUserStatus>();
        }

        public int SystemCheckComponentTypeId { get; set; }
        public string ComponentName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public bool IsManualCheck { get; set; }
        public string BrowserHawkId { get; set; }
        public string Xhtmlquestion { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<SystemCheckUserStatus> SystemCheckUserStatus { get; set; }
    }
}
