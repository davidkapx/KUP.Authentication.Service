using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnEventQueryExecutionStateHistory
    {
        public int EventQueryExecutionStateHistoryId { get; set; }
        public Guid EventId { get; set; }
        public DateTime ExecutionDate { get; set; }
        public int CountSuccessful { get; set; }
        public int CountIgnored { get; set; }
        public int CountErrored { get; set; }

        public virtual EnEvent Event { get; set; }
    }
}
