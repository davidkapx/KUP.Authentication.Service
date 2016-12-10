using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class AdminAccountProvisioning
    {
        public int Aaid { get; set; }
        public string AduserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool? Imported { get; set; }
        public string Message { get; set; }
        public byte[] Ts { get; set; }
    }
}
