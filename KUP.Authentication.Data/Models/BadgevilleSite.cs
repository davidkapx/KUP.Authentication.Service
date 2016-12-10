using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class BadgevilleSite
    {
        public int BadgevilleSiteId { get; set; }
        public string Name { get; set; }
        public string CreatedAt { get; set; }
        public string Url { get; set; }
        public string Id { get; set; }
        public string NetworkId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
