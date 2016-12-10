using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class BadgevilleUser
    {
        public int BadgevilleUserId { get; set; }
        public string Name { get; set; }
        public string CreatedAt { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
