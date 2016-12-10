using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class OnlineFormsRequestType
    {
        public OnlineFormsRequestType()
        {
            OnlineFormsRequest = new HashSet<OnlineFormsRequest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<OnlineFormsRequest> OnlineFormsRequest { get; set; }
    }
}
