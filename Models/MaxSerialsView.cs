using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class MaxSerialsView
    {
        public string StoCode { get; set; }
        public string TerminalId { get; set; }
        public int? MaxSerial { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string Module { get; set; }
    }
}
