using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PasswordChangeLog
    {
        public int Id { get; set; }
        public int PortalUserId { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime DateOfChange { get; set; }
        public byte[] Ts { get; set; }
    }
}
