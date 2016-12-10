using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class Presentation
    {
        public Presentation()
        {
            PresentationAnswer = new HashSet<PresentationAnswer>();
            PresentationAssignment = new HashSet<PresentationAssignment>();
            PresentationPresentationFile = new HashSet<PresentationPresentationFile>();
            PresentationQuestion = new HashSet<PresentationQuestion>();
            PresentationViewLog = new HashSet<PresentationViewLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string Owner { get; set; }
        public bool Enabled { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EnabledChangeDate { get; set; }

        public virtual ICollection<PresentationAnswer> PresentationAnswer { get; set; }
        public virtual ICollection<PresentationAssignment> PresentationAssignment { get; set; }
        public virtual ICollection<PresentationPresentationFile> PresentationPresentationFile { get; set; }
        public virtual ICollection<PresentationQuestion> PresentationQuestion { get; set; }
        public virtual ICollection<PresentationViewLog> PresentationViewLog { get; set; }
    }
}
