using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class UserStatusType
    {
        public UserStatusType()
        {
            UserStatus = new HashSet<UserStatus>();
        }

        public int UserStatusTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<UserStatus> UserStatus { get; set; }
    }
}
