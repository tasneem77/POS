using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class KitchenOrder
    {
        public int Id { get; set; }
        public int? ItmSerial { get; set; }
        public decimal? TrnsQty { get; set; }
        public int? UnitId { get; set; }
        public int? LineSerial { get; set; }
        public int? KitchenId { get; set; }
        public string TransNo { get; set; }
        public string TransTypeCodeL1 { get; set; }
        public int? TerminalId { get; set; }
        public string StoCode { get; set; }
        public int? ShId { get; set; }
        public DateTime? OrderTime { get; set; }
        public string OrderUser { get; set; }
        public int? OrderFlag { get; set; }
        public string MajorTime { get; set; }
        public DateTime? FinishTime { get; set; }
    }
}
