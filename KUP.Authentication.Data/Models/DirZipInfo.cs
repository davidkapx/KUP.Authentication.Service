using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirZipInfo
    {
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public short TimeZone { get; set; }
        public bool ObservesDst { get; set; }
    }
}
