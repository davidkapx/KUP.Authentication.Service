using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class InstructorAccountProvisioning
    {
        public int SyStaffId { get; set; }
        public int? SyCampusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AduserName { get; set; }
        public string EmailAddress { get; set; }
        public string EmployeeNumber { get; set; }
        public bool? Imported { get; set; }
        public string Message { get; set; }
        public byte[] Ts { get; set; }
    }
}
