using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class QbResponseState
    {
        public QbResponseState()
        {
            QbInquiry = new HashSet<QbInquiry>();
            QbResponseStatePermission = new HashSet<QbResponseStatePermission>();
            QbResponseStateTransitionResponseState = new HashSet<QbResponseStateTransition>();
            QbResponseStateTransitionTransitionToState = new HashSet<QbResponseStateTransition>();
        }

        public int ResponseStateId { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public int Ordinal { get; set; }

        public virtual ICollection<QbInquiry> QbInquiry { get; set; }
        public virtual ICollection<QbResponseStatePermission> QbResponseStatePermission { get; set; }
        public virtual ICollection<QbResponseStateTransition> QbResponseStateTransitionResponseState { get; set; }
        public virtual ICollection<QbResponseStateTransition> QbResponseStateTransitionTransitionToState { get; set; }
    }
}
