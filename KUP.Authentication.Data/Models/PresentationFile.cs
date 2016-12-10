using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PresentationFile
    {
        public PresentationFile()
        {
            PresentationPresentationFile = new HashSet<PresentationPresentationFile>();
            PresentationQuestion = new HashSet<PresentationQuestion>();
        }

        public int Id { get; set; }
        public string Owner { get; set; }
        public string Filename { get; set; }
        public string Url { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Subunits { get; set; }

        public virtual ICollection<PresentationPresentationFile> PresentationPresentationFile { get; set; }
        public virtual ICollection<PresentationQuestion> PresentationQuestion { get; set; }
    }
}
