using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnEventStoredProcedure
    {
        public EnEventStoredProcedure()
        {
            EnEventStoredProcedureParameter = new HashSet<EnEventStoredProcedureParameter>();
        }

        public int EventStoredProcedureId { get; set; }
        public Guid EventId { get; set; }
        public string StoredProcedureName { get; set; }
        public string ConnectionStringName { get; set; }
        public string JoinKeyColumnName { get; set; }
        public bool ContainsDuplicateKeys { get; set; }
        public int Ordinal { get; set; }
        public DateTime? LastExecutionDate { get; set; }

        public virtual ICollection<EnEventStoredProcedureParameter> EnEventStoredProcedureParameter { get; set; }
        public virtual EnEvent Event { get; set; }
    }
}
