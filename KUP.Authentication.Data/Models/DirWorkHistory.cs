using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirWorkHistory
    {
        public int DirWorkHistoryId { get; set; }
        public int PortalUserId { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }

        public virtual DirUserProfile PortalUser { get; set; }
    }
}
