using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PresentationGroupType
    {
        public PresentationGroupType()
        {
            PresentationAssignment = new HashSet<PresentationAssignment>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PresentationAssignment> PresentationAssignment { get; set; }
    }
}
