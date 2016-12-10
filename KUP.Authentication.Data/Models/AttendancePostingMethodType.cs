using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class AttendancePostingMethodType
    {
        public AttendancePostingMethodType()
        {
            AttendancePostingMethod = new HashSet<AttendancePostingMethod>();
        }

        public int AttendancePostingMethodTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AttendancePostingMethod> AttendancePostingMethod { get; set; }
    }
}
