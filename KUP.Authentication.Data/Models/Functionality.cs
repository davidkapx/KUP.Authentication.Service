using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class Functionality
    {
        public Functionality()
        {
            UserStatusFunctionality = new HashSet<UserStatusFunctionality>();
        }

        public int FunctionalityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<UserStatusFunctionality> UserStatusFunctionality { get; set; }
    }
}
