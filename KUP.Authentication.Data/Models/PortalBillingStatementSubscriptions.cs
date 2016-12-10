using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalBillingStatementSubscriptions
    {
        public int PortalBillingStatementSubscriptionId { get; set; }
        public int StudentId { get; set; }
        public string Username { get; set; }
        public DateTime OptInDate { get; set; }
        public DateTime? OptOutDate { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}
