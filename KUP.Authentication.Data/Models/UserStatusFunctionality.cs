using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class UserStatusFunctionality
    {
        public int UserStatusFunctionalityId { get; set; }
        public int UserStatusId { get; set; }
        public int FunctionalityId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual Functionality Functionality { get; set; }
        public virtual UserStatus UserStatus { get; set; }
    }
}
