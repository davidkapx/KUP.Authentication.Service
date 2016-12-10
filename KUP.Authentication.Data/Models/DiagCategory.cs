using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DiagCategory
    {
        public DiagCategory()
        {
            DiagCategoryLog = new HashSet<DiagCategoryLog>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<DiagCategoryLog> DiagCategoryLog { get; set; }
    }
}
