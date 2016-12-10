using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirContactRequestStatus
    {
        public DirContactRequestStatus()
        {
            DirUserContactRequest = new HashSet<DirUserContactRequest>();
        }

        public byte DirContactRequestStatusId { get; set; }
        public string StatusName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DirUserContactRequest> DirUserContactRequest { get; set; }
    }
}
