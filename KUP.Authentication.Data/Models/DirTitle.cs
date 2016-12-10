using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirTitle
    {
        public DirTitle()
        {
            DirUserProfile = new HashSet<DirUserProfile>();
        }

        public byte DirTitleId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }

        public virtual ICollection<DirUserProfile> DirUserProfile { get; set; }
    }
}
