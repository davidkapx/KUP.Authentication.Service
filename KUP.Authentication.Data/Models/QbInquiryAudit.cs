using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbInquiryAudit
    {
        public int InquiryAuditId { get; set; }
        public int InquiryId { get; set; }
        public int SubjectId { get; set; }
        public string OtherSubject { get; set; }
        public string InquiryText { get; set; }
        public int ResponseStateId { get; set; }
        public int? Smeid { get; set; }
        public string ResponseXhtml { get; set; }
        public string ReviewerNotes { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual QbInquiry Inquiry { get; set; }
        public virtual QbSubject Subject { get; set; }
    }
}
