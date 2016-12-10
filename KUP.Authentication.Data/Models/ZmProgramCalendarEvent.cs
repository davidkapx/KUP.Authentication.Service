using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ZmProgramCalendarEvent
    {
        public ZmProgramCalendarEvent()
        {
            ZmProgramCalendarEventInstance = new HashSet<ZmProgramCalendarEventInstance>();
        }

        public int ProgramCalendarEventId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public short? StartOffsetDays { get; set; }
        public short? StartOffsetPercent { get; set; }
        public short? EndOffsetDays { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<ZmProgramCalendarEventInstance> ZmProgramCalendarEventInstance { get; set; }
    }
}
