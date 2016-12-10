using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbResponseStatePermission
    {
        public int ResponseStatePermissionId { get; set; }
        public int ResponseStateId { get; set; }
        public string Permission { get; set; }

        public virtual QbResponseState ResponseState { get; set; }
    }
}
