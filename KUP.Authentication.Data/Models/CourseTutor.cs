using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CourseTutor
    {
        public int CourseTutorId { get; set; }
        public int? ProgramId { get; set; }
        public int? CourseId { get; set; }
        public string CatalogNumber { get; set; }
        public int? TrackingId { get; set; }
        public bool? NetTutorEnabled { get; set; }
        public bool? SmartThinkingEnabled { get; set; }
        public string LastUpdateBy { get; set; }
        public byte[] Ts { get; set; }
    }
}
