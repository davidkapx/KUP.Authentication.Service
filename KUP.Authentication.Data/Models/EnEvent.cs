using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnEvent
    {
        public EnEvent()
        {
            EnEventMessageTemplate = new HashSet<EnEventMessageTemplate>();
            EnEventQueryColumnSchema = new HashSet<EnEventQueryColumnSchema>();
            EnEventQueryExecutionStateHistory = new HashSet<EnEventQueryExecutionStateHistory>();
            EnEventStoredProcedure = new HashSet<EnEventStoredProcedure>();
        }

        public Guid EventId { get; set; }
        public string EventBrokerEventName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
        public bool IsSubscribable { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsLoggingEnabled { get; set; }
        public string DefaultEmail { get; set; }

        public virtual CmxActivityFromEventConfig CmxActivityFromEventConfig { get; set; }
        public virtual ICollection<EnEventMessageTemplate> EnEventMessageTemplate { get; set; }
        public virtual ICollection<EnEventQueryColumnSchema> EnEventQueryColumnSchema { get; set; }
        public virtual ICollection<EnEventQueryExecutionStateHistory> EnEventQueryExecutionStateHistory { get; set; }
        public virtual ICollection<EnEventStoredProcedure> EnEventStoredProcedure { get; set; }
    }
}
