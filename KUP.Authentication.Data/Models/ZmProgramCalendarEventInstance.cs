using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ZmProgramCalendarEventInstance
    {
        public int ProgramCalendarEventInstanceId { get; set; }
        public int? ProgramEnrollmentId { get; set; }
        public int? ProgramCalendarEventId { get; set; }
        public string CalendarEventInviteId { get; set; }
        public int? CalendarEventComponentNumber { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ZmProgramCalendarEvent ProgramCalendarEvent { get; set; }
    }
}
