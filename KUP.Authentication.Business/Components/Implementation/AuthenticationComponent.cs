using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KUP.Authentication.Data;
using KUP.Authentication.Business.Components.Definition;
using KUP.Authentication.Data.Repositories.Definition;
using System.Text;
using System.Security.Cryptography;
using KUP.Authentication.Business.Models.Enums;
using KUP.Authentication.Business.Components.Security;
using KUP.Authentication.Business.Models;

namespace KUP.Authentication.Business.Components.Implementation
{
    public class AuthenticationComponent : BaseComponent, IAuthenticationComponent
    {
        private readonly IPortalUserRepository _portalUserRepository;

        public AuthenticationComponent(IPortalUserRepository portalUserRepository)
        {
            _portalUserRepository = portalUserRepository;
        }

        public AuthenticationResult Authenticate (string userName, string passWord)
        {
            AuthenticationResult result = AuthenticationResult.LogonFailure;

            PortalUser portalUser = MapPortalUser(_portalUserRepository.GetPortalUserByUserName(userName));
            if (portalUser != null)
            {
                string encodedPassword = EncodePassword(passWord, portalUser.PasswordFormat, portalUser.PasswordSalt);

                if (string.Compare(portalUser.Password, encodedPassword, StringComparison.Ordinal) == 0)
                    result = AuthenticationResult.Successful;

            }

            return result;
        }

        private string EncodePassword(string pass, PasswordFormat passwordFormat, string salt)
        {
            if (passwordFormat == PasswordFormat.Clear)
                return pass;

            byte[] bIn = Encoding.Unicode.GetBytes(pass), bSalt = Convert.FromBase64String(salt), hash = null;
            byte[] bAll = new byte[bSalt.Length + bIn.Length];

            Buffer.BlockCopy(bSalt, 0, bAll, 0, bSalt.Length);
            Buffer.BlockCopy(bIn, 0, bAll, bSalt.Length, bIn.Length);

            if (passwordFormat == PasswordFormat.Hashed)
            {

                // Password is hashed
                //HashAlgorithm ha = HashAlgorithm.Create("SHA1");  // 'SHA1' is typically used by Membership.
                var sha1 = SHA1.Create();
                hash = sha1.ComputeHash(bAll);
            }
            else
            {
                // Password is encrypted
                hash = RijndaelCrypto.EncryptToBytes(Encoding.Unicode.GetBytes(pass));
            }

            return Convert.ToBase64String(hash);
        }
    }
}
