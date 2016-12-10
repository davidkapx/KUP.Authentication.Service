using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class LiveHelp
    {
        public LiveHelp()
        {
            LiveHelpBusinessUnit = new HashSet<LiveHelpBusinessUnit>();
        }

        public int LiveHelpId { get; set; }
        public int? CampusId { get; set; }
        public bool? Enabled { get; set; }
        public bool? Visible { get; set; }
        public string ImageUrl { get; set; }
        public string DisplayText { get; set; }
        public string DisabledText { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }

        public virtual ICollection<LiveHelpBusinessUnit> LiveHelpBusinessUnit { get; set; }
    }
}
