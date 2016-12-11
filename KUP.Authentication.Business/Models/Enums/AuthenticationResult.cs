using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Business.Models.Enums
{
    public enum AuthenticationResult
    {
        LogonFailure = 0,
        PasswordExpired = 1,
        PasswordReset = 2,
        Successful = 3,
        SuccessfulFirstTime = 4,
        RequiresVerification = 5,
        RequiresManualVerification = 6,
        VerifiedButNotProvisioned = 7,
        AccountIsLocked = 8,
        TokenInvalid = 9,
        AccountNotFound = 10
    }
}
