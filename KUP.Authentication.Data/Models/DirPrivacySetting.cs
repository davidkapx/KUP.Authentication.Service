using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirPrivacySetting
    {
        public DirPrivacySetting()
        {
            DirUserPrivacySetting = new HashSet<DirUserPrivacySetting>();
        }

        public int DirPrivacySettingId { get; set; }
        public string PrivacySettingName { get; set; }
        public string PrivacySettingDescription { get; set; }

        public virtual ICollection<DirUserPrivacySetting> DirUserPrivacySetting { get; set; }
    }
}
