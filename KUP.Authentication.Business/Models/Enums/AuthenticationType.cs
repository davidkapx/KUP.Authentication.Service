using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUP.Authentication.Business.Models.Enums
{
    public enum AuthenticationType : short
    {
        None = 0,
        ActiveDirectory = 1,
        Database = 2
    }
}
