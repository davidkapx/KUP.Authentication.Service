using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class OrionBusinessUnitTicketType
    {
        public int BusinessUnitId { get; set; }
        public int OrionTicketDescriptionId { get; set; }
        public int TicketTypeId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
