using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KUP.Authentication.Business.Models.Enums;
using KUP.Authentication.Business.Models;

namespace KUP.Authentication.Business.Components
{
    public class BaseComponent
    {

        protected PortalUser MapPortalUser(KUP.Authentication.Data.Models.PortalUser portalUser)
        {
            if (portalUser == null)
                return null;

            return new PortalUser()
            {
                ADDomainName = (portalUser.AdAuthenticationDomain == null)
                                    ? string.Empty
                                    : portalUser.AdAuthenticationDomain.DomainName,
                ADUserName = portalUser.Adusername,
                //AuthenticationType = (AuthenticationType)portalUser.AuthenticationType.AuthenticationTypeId,
                IsLocked = portalUser.IsLockedOut,
                LastLogin = portalUser.LastLoginDate,
                Password = portalUser.Password,
                PasswordFormat = (PasswordFormat)portalUser.PasswordFormat,
                PasswordSalt = portalUser.PasswordSalt,
                RequirePasswordChange = portalUser.RequirePasswordChange,
                PortalUserId = portalUser.PortalUserId,
                UserName = portalUser.Username,
                FirstName = portalUser.FirstName,
                LastName = portalUser.LastName,
                LastLockoutDate = portalUser.LastLockoutDate,
                PasswordChangeDate = portalUser.LastPasswordChangedDate,
                Attributes = (from a in portalUser.PortalUserAttribute select new { a.Attribute, a.Value }).Distinct().ToDictionary(a => a.Attribute, a => a.Value)
            };
        }
    }
}
