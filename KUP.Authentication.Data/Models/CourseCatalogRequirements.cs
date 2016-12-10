using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CourseCatalogRequirements
    {
        public int CourseCatalogRequirementId { get; set; }
        public int CourseId { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool BlockSelfRegistration { get; set; }
    }
}
