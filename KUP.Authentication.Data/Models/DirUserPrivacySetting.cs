using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirUserPrivacySetting
    {
        public int DirUserPrivacySettingId { get; set; }
        public int PortalUserId { get; set; }
        public int DirPrivacySettingId { get; set; }
        public bool HasStaffPermission { get; set; }
        public bool HasNetworkPermission { get; set; }
        public bool HasStudentPermission { get; set; }

        public virtual DirPrivacySetting DirPrivacySetting { get; set; }
        public virtual DirUserProfile PortalUser { get; set; }
    }
}
