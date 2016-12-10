using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DegreePlanTicket
    {
        public int DegreePlanTicketId { get; set; }
        public int TicketId { get; set; }
        public int ProgramEnrollmentId { get; set; }
        public int CourseId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
