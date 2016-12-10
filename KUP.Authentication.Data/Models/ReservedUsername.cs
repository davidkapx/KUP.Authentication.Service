using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ReservedUsername
    {
        public int ReservedUsernameId { get; set; }
        public string UserName { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
