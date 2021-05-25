using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Printer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string PrinterName { get; set; }
        public string PrinterTag { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
    }
}
