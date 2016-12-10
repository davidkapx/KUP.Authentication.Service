using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbSubject
    {
        public QbSubject()
        {
            QbInquiry = new HashSet<QbInquiry>();
            QbInquiryAudit = new HashSet<QbInquiryAudit>();
        }

        public int SubjectId { get; set; }
        public string Name { get; set; }
        public bool IsForFaculty { get; set; }
        public int Ordinal { get; set; }

        public virtual ICollection<QbInquiry> QbInquiry { get; set; }
        public virtual ICollection<QbInquiryAudit> QbInquiryAudit { get; set; }
    }
}
