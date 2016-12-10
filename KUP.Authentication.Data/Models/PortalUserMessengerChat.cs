using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserMessengerChat
    {
        public PortalUserMessengerChat()
        {
            PortalUserMessengerChatMessage = new HashSet<PortalUserMessengerChatMessage>();
            PortalUserMessengerChatParticipator = new HashSet<PortalUserMessengerChatParticipator>();
        }

        public int MessengerChatId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<PortalUserMessengerChatMessage> PortalUserMessengerChatMessage { get; set; }
        public virtual ICollection<PortalUserMessengerChatParticipator> PortalUserMessengerChatParticipator { get; set; }
    }
}
