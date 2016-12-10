using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DiagCategoryLog
    {
        public int CategoryLogId { get; set; }
        public int CategoryId { get; set; }
        public int LogId { get; set; }

        public virtual DiagCategory Category { get; set; }
        public virtual DiagLog Log { get; set; }
    }
}
