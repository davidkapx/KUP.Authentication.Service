using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DiagLog
    {
        public DiagLog()
        {
            DiagCategoryLog = new HashSet<DiagCategoryLog>();
        }

        public int LogId { get; set; }
        public int? EventId { get; set; }
        public int Priority { get; set; }
        public string Severity { get; set; }
        public string Title { get; set; }
        public DateTime Timestamp { get; set; }
        public string MachineName { get; set; }
        public string AppDomainName { get; set; }
        public string ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string ThreadName { get; set; }
        public string Win32ThreadId { get; set; }
        public string Message { get; set; }
        public string FormattedMessage { get; set; }
        public string IdentityName { get; set; }
        public string SourceApplication { get; set; }
        public string ErrorType { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSite { get; set; }
        public string InnerException { get; set; }
        public bool? IsAuthenticated { get; set; }
        public string Details { get; set; }

        public virtual ICollection<DiagCategoryLog> DiagCategoryLog { get; set; }
    }
}
