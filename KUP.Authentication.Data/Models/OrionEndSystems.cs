using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class OrionEndSystems
    {
        public int BusinessUnitId { get; set; }
        public string EndSystem { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
