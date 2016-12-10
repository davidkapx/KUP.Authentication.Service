using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PresentationPresentationFile
    {
        public int PresentationPresentationFileId { get; set; }
        public int PresentationId { get; set; }
        public int PresentationFileId { get; set; }
        public int Position { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }

        public virtual PresentationFile PresentationFile { get; set; }
        public virtual Presentation Presentation { get; set; }
    }
}
