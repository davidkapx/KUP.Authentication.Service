using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class OnlineFormsRequest
    {
        public int Id { get; set; }
        public int RequestType { get; set; }
        public int StudentId { get; set; }
        public int InstructorId { get; set; }
        public int? DelegateId { get; set; }
        public int ClassId { get; set; }
        public int TicketId { get; set; }
        public string NewGrade { get; set; }
        public string OldGrade { get; set; }
        public string NewLetterGrade { get; set; }
        public string OldLetterGrade { get; set; }
        public string Communication { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual OnlineFormsRequestType RequestTypeNavigation { get; set; }
        public virtual OnlineFormsRequestStatus StatusNavigation { get; set; }
    }
}
