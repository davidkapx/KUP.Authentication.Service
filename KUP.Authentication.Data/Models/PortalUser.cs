using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class PortalUser
    {
        public PortalUser()
        {
            EnUserContactSettings = new HashSet<EnUserContactSettings>();
            EnUserEventSubscription = new HashSet<EnUserEventSubscription>();
            PortalNotification = new HashSet<PortalNotification>();
            PortalUserAttribute = new HashSet<PortalUserAttribute>();
            PortalUserLogin = new HashSet<PortalUserLogin>();
            PortalUserMapping = new HashSet<PortalUserMapping>();
            PortalUserMessengerChatMessage = new HashSet<PortalUserMessengerChatMessage>();
            PortalUserMessengerChatParticipator = new HashSet<PortalUserMessengerChatParticipator>();
            PortalUserMessengerSignInLog = new HashSet<PortalUserMessengerSignInLog>();
            PortalUserRole = new HashSet<PortalUserRole>();
            PortalUserSystemActionAudit = new HashSet<PortalUserSystemActionAudit>();
            SystemCheckUserStatus = new HashSet<SystemCheckUserStatus>();
        }

        public int PortalUserId { get; set; }
        public short AuthenticationTypeId { get; set; }
        public int? AdAuthenticationDomainId { get; set; }
        public string Adusername { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public string TimeZoneId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public Guid? Guid { get; set; }
        public byte[] Ts { get; set; }
        public int PrimaryCampusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsLockedOut { get; set; }
        public int FailedLoginAttemptCount { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public DateTime? LastLockoutDate { get; set; }
        public DateTime? LastTemporaryPasswordIssueDate { get; set; }
        public DateTime? TemporaryPasswordExpirationDate { get; set; }
        public bool RequirePasswordChange { get; set; }

        public virtual DirUserProfile DirUserProfile { get; set; }
        public virtual ICollection<EnUserContactSettings> EnUserContactSettings { get; set; }
        public virtual ICollection<EnUserEventSubscription> EnUserEventSubscription { get; set; }
        public virtual ICollection<PortalNotification> PortalNotification { get; set; }
        public virtual ICollection<PortalUserAttribute> PortalUserAttribute { get; set; }
        public virtual ICollection<PortalUserLogin> PortalUserLogin { get; set; }
        public virtual ICollection<PortalUserMapping> PortalUserMapping { get; set; }
        public virtual ICollection<PortalUserMessengerChatMessage> PortalUserMessengerChatMessage { get; set; }
        public virtual ICollection<PortalUserMessengerChatParticipator> PortalUserMessengerChatParticipator { get; set; }
        public virtual ICollection<PortalUserMessengerSignInLog> PortalUserMessengerSignInLog { get; set; }
        public virtual ICollection<PortalUserRole> PortalUserRole { get; set; }
        public virtual ICollection<PortalUserSystemActionAudit> PortalUserSystemActionAudit { get; set; }
        public virtual ICollection<SystemCheckUserStatus> SystemCheckUserStatus { get; set; }
        public virtual AdAuthenticationDomain AdAuthenticationDomain { get; set; }
        public virtual AuthenticationType AuthenticationType { get; set; }
    }
}
