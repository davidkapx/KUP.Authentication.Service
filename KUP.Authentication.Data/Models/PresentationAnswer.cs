using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PresentationAnswer
    {
        public int PresentationAnswerId { get; set; }
        public int PresentationId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public DateTime AnsweredDate { get; set; }
        public int? Unit { get; set; }
        public int? Subunit { get; set; }

        public virtual Presentation Presentation { get; set; }
    }
}
