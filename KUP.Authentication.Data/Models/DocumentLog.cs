using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DocumentLog
    {
        public int DocumentLogId { get; set; }
        public int? DocumentId { get; set; }
        public int? StudentId { get; set; }
        public int? DocumentStudentId { get; set; }
        public string IpAddress { get; set; }
        public string Message { get; set; }
        public byte[] Ts { get; set; }
    }
}
