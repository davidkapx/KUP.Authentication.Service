using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class InsConcernStatus
    {
        public int ConcernStatusId { get; set; }
        public string ConcernStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
