using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class TranscriptItemCost
    {
        public int TranscriptItemCostId { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
