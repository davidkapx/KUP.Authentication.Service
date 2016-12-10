using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PresentationAssignment
    {
        public int PresentationAssignmentId { get; set; }
        public int PresentationId { get; set; }
        public int CampusId { get; set; }
        public int GroupId { get; set; }
        public int PresentationGroupTypeId { get; set; }
        public bool IsCampusTour { get; set; }
        public bool Enabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual PresentationGroupType PresentationGroupType { get; set; }
        public virtual Presentation Presentation { get; set; }
    }
}
