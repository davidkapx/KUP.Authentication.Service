using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbSubjectMatterExpert
    {
        public QbSubjectMatterExpert()
        {
            QbInquiry = new HashSet<QbInquiry>();
        }

        public int Smeid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public int? PhotoFileId { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<QbInquiry> QbInquiry { get; set; }
    }
}
