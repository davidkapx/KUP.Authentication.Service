using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class StudentTutor
    {
        public int StudentTutorId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string CatalogNumber { get; set; }
        public string CourseSection { get; set; }
        public int ClassSchedId { get; set; }
        public bool? Enabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
