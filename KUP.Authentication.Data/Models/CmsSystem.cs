using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class CmsSystem
    {
        public int SystemId { get; set; }
        public string SystemName { get; set; }
        public long ContentGeneration { get; set; }
        public long ScheduleGeneration { get; set; }
        public long ProjectGeneration { get; set; }
        public long SiteMapGeneration { get; set; }
        public long TemplateGeneration { get; set; }
        public long VirtualPageGeneration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
