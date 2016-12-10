using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class InsConcernType
    {
        public InsConcernType()
        {
            InsConcern = new HashSet<InsConcern>();
        }

        public int ConcernTypeId { get; set; }
        public string ConcernType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<InsConcern> InsConcern { get; set; }
    }
}
