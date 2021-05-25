using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SystemLog
    {
        public string LogNo { get; set; }
        public string StoCode { get; set; }
        public int? TerminalId { get; set; }
        public string UserId { get; set; }
        public string Remarks { get; set; }
    }
}
