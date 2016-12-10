using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class BadgevillePlayer
    {
        public int BadgevillePlayerId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string SiteId { get; set; }
        public string SiteUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
