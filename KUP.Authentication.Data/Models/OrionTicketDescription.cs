using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class OrionTicketDescription
    {
        public int OrionTicketDescriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
