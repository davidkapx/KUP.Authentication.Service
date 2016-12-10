using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUserMessengerChatMessage
    {
        public int MessengerChatMessageId { get; set; }
        public int? MessengerChatId { get; set; }
        public int? MessageHash { get; set; }
        public int? PortalUserId { get; set; }
        public string Message { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UtccreateDate { get; set; }

        public virtual PortalUserMessengerChat MessengerChat { get; set; }
        public virtual PortalUser PortalUser { get; set; }
    }
}
