using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class EnEventStoredProcedureParameter
    {
        public int EventStoredProcedureParameterId { get; set; }
        public int EventStoredProcedureId { get; set; }
        public string ParameterName { get; set; }
        public string ParameterType { get; set; }
        public string ParameterValue { get; set; }

        public virtual EnEventStoredProcedure EventStoredProcedure { get; set; }
    }
}
