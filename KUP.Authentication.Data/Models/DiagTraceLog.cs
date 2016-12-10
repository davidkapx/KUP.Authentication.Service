using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DiagTraceLog
    {
        public int TraceLogId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string Category { get; set; }
        public string ApplicationName { get; set; }
        public string MachineName { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int ThreadId { get; set; }
        public int ThreadSequenceNumber { get; set; }
        public string StackTrace { get; set; }
    }
}
