using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesMan
    {
        public int SalesSerial { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string ComCode { get; set; }
        public string Smcode { get; set; }
        public decimal? CommPercentage { get; set; }
        public bool? Status { get; set; }
        public DateTime LastUpdate { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
