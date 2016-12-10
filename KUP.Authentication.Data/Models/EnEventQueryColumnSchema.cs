using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnEventQueryColumnSchema
    {
        public int EventQueryColumnSchemaId { get; set; }
        public Guid EventId { get; set; }
        public string ColumnName { get; set; }

        public virtual EnEvent Event { get; set; }
    }
}
