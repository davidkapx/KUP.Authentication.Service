using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class TranscriptSession
    {
        public int TranscriptSessionId { get; set; }
        public int StudentId { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal? TotalFee { get; set; }
        public int PaymentTypeId { get; set; }
        public bool? IsSent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
