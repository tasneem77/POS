using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemStatusChange
    {
        public int ItmSerial { get; set; }
        public int? AllowSales { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string UserId { get; set; }
        public string StoCode { get; set; }
        public int? TerminalId { get; set; }
    }
}
