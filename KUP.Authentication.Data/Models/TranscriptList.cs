using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class TranscriptList
    {
        public int TranscriptListId { get; set; }
        public int TranscriptSessionId { get; set; }
        public bool? Primary { get; set; }
        public int InstituteId { get; set; }
        public int Order { get; set; }
        public int SendToId { get; set; }
        public int PurposeId { get; set; }
        public int ProcessingId { get; set; }
        public int? SourceType { get; set; }
        public string Recipient1 { get; set; }
        public string Recipient2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int? NumberOfCopies { get; set; }
        public decimal? Amount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
