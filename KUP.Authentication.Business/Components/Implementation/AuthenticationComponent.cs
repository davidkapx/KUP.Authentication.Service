﻿using System;
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
using KUP.Framework.Common.Security.JwtToken;
using System.Security.Claims;

namespace KUP.Authentication.Business.Components.Implementation
{
    public class AuthenticationComponent : BaseComponent, IAuthenticationComponent
    {
        private readonly IPortalUserRepository _portalUserRepository;
        private readonly IJwtTokenComponent _jwtTokenComponent;

        public AuthenticationComponent(IPortalUserRepository portalUserRepository, IJwtTokenComponent jwtTokenComponent)
        {
            _portalUserRepository = portalUserRepository;
            _jwtTokenComponent = jwtTokenComponent;
        }

        public AuthenticateResult Authenticate(string userName, string passWord)
        {
            AuthenticateResult authResult = new AuthenticateResult();

            PortalUser portalUser = MapPortalUser(_portalUserRepository.GetPortalUserByUserName(userName));
            if (portalUser != null)
            {
                string encodedPassword = EncodePassword(passWord, portalUser.PasswordFormat, portalUser.PasswordSalt);

                if (string.Compare(portalUser.Password, encodedPassword, StringComparison.Ordinal) == 0)
                {
                   
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
                    {
                     new Claim("client_id", "KUP.Authentication.API"),
                     new Claim("StudentID", portalUser.PortalUserId.ToString()),
                     new Claim("PrimaryCampusID", "43"),
                     new Claim("CanActAsStudent","true"),
                     new Claim("CanActAsInstructor","false"),
                     new Claim("IsActingAsInstructor","false"),
                     new Claim("IsActingAsStudent","true"),
                     new Claim("IsImpersonator", "false"),

                    });

                    authResult.LoginResult = AuthenticationResult.Successful.ToString();
                    authResult.JWT_Token = _jwtTokenComponent.EncryptToken(claimsIdentity);



                }
                else
                    authResult.LoginResult = AuthenticationResult.LogonFailure.ToString();

            }

            return authResult;
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