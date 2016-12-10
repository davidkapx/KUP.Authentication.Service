using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class StudentAccountProvisioning
    {
        public int SyStudentId { get; set; }
        public int? SyCampusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? Imported { get; set; }
        public string Message { get; set; }
        public byte[] Ts { get; set; }
        public string PortalUsername { get; set; }
    }
}
