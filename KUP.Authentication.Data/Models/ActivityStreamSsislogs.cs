using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ActivityStreamSsislogs
    {
        public int ActivityStreamSsislogId { get; set; }
        public string LogType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string LogInfo { get; set; }
    }
}
