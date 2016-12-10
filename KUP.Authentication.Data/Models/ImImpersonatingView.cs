using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class ImImpersonatingView
    {
        public int ImpersonatingId { get; set; }
        public int UserId { get; set; }
        public bool Selected { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImpersonatingUserId { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
