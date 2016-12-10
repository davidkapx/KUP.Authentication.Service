using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class LiveHelpBusinessUnit
    {
        public int LiveHelpBusinessUnitId { get; set; }
        public int? LiveHelpId { get; set; }
        public string Name { get; set; }
        public bool? Enabled { get; set; }
        public bool? Visible { get; set; }
        public string LiveHelpUrl { get; set; }
        public string ToolTip { get; set; }
        public string DisabledText { get; set; }
        public string ImageUrl { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }

        public virtual LiveHelp LiveHelp { get; set; }
    }
}
