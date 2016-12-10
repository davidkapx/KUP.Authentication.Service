using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PresentationViewLog
    {
        public int ViewId { get; set; }
        public int PresentationId { get; set; }
        public int UserId { get; set; }
        public string PresentationPosition { get; set; }
        public bool IsCampusTour { get; set; }
        public DateTime ViewDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Presentation Presentation { get; set; }
    }
}
