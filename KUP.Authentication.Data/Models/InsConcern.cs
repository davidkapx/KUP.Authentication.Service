using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class InsConcern
    {
        public int ConcernId { get; set; }
        public int? StudentId { get; set; }
        public int? InstructorId { get; set; }
        public int? AdClassSchedId { get; set; }
        public int? ConcernType { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual InsConcernType ConcernTypeNavigation { get; set; }
    }
}
