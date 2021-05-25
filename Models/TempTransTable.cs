using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TempTransTable
    {
        public int Id { get; set; }
        public int? ItmSerial { get; set; }
        public string UnitType { get; set; }
        public int? UnitCode { get; set; }
        public string UnitName { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public string UserCode { get; set; }
        public DateTime? TransDate { get; set; }
        public string StoCode { get; set; }
        public string TransTypeCode { get; set; }
    }
}
