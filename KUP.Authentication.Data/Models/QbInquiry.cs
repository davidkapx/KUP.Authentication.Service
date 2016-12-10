using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbInquiry
    {
        public QbInquiry()
        {
            QbInquiryAudit = new HashSet<QbInquiryAudit>();
        }

        public int InquiryId { get; set; }
        public int SubmitterPortalUserId { get; set; }
        public bool SubmitterIsFaculty { get; set; }
        public int InquiryTypeId { get; set; }
        public int SubjectId { get; set; }
        public string OtherSubject { get; set; }
        public string InquiryText { get; set; }
        public int ResponseStateId { get; set; }
        public int? Smeid { get; set; }
        public string ResponseXhtml { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerNotes { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<QbInquiryAudit> QbInquiryAudit { get; set; }
        public virtual QbInquiryType InquiryType { get; set; }
        public virtual QbResponseState ResponseState { get; set; }
        public virtual QbSubjectMatterExpert Sme { get; set; }
        public virtual QbSubject Subject { get; set; }
    }
}
