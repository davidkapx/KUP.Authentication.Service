using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbResponseStateTransition
    {
        public int ResponseStateTransitionId { get; set; }
        public int ResponseStateId { get; set; }
        public int TransitionToStateId { get; set; }

        public virtual QbResponseState ResponseState { get; set; }
        public virtual QbResponseState TransitionToState { get; set; }
    }
}
