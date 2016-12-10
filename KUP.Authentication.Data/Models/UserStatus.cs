using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            UserStatusFunctionality = new HashSet<UserStatusFunctionality>();
        }

        public int UserStatusId { get; set; }
        public int UserStatusTypeId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int CampusId { get; set; }
        public bool IsActive { get; set; }
        public bool BlockActive { get; set; }
        public string BlockComment { get; set; }
        public Guid? EventId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<UserStatusFunctionality> UserStatusFunctionality { get; set; }
        public virtual UserStatusType UserStatusType { get; set; }
    }
}
