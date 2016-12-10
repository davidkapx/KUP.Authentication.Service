using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PresentationQuestion
    {
        public PresentationQuestion()
        {
            PresentationQuestionAnswer = new HashSet<PresentationQuestionAnswer>();
        }

        public int QuestionId { get; set; }
        public int PresentationId { get; set; }
        public int PresentationFileId { get; set; }
        public int PresentationQuestionTypeId { get; set; }
        public string Question { get; set; }
        public int SequenceNumber { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual ICollection<PresentationQuestionAnswer> PresentationQuestionAnswer { get; set; }
        public virtual PresentationFile PresentationFile { get; set; }
        public virtual Presentation Presentation { get; set; }
    }
}
