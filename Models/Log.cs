using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Log
    {
        public string UserId { get; set; }
        public int? AcId { get; set; }
        public DateTime? LogStart { get; set; }
        public DateTime? LogEnd { get; set; }
        public string Note { get; set; }
        public string SalesTrnsId { get; set; }
    }
}
