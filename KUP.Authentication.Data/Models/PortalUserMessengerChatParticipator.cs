using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserMessengerChatParticipator
    {
        public int MessengerChatParticipatorId { get; set; }
        public int? MessengerChatId { get; set; }
        public int? PortalUserId { get; set; }

        public virtual PortalUserMessengerChat MessengerChat { get; set; }
        public virtual PortalUser PortalUser { get; set; }
    }
}
