using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class MilitaryTuitionRatesCdltracking
    {
        public int Militarytuitionratescdltrackingid { get; set; }
        public int Studentid { get; set; }
        public int Termid { get; set; }
        public int Documentscheduleid { get; set; }
        public string Createdby { get; set; }
        public DateTime Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime Modifieddate { get; set; }
    }
}
