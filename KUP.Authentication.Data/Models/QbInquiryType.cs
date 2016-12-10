using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbInquiryType
    {
        public QbInquiryType()
        {
            QbInquiry = new HashSet<QbInquiry>();
        }

        public int InquiryTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QbInquiry> QbInquiry { get; set; }
    }
}
