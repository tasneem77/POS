using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemStoreSerialNoStockInOutView
    {
        public int ItmSerial { get; set; }
        public string SerialNo { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public bool? AvailabilityInStock { get; set; }
        public string InReference { get; set; }
        public DateTime? InDate { get; set; }
        public decimal? InCost { get; set; }
        public string OutReference { get; set; }
        public DateTime? OutDate { get; set; }
        public decimal? OutCost { get; set; }
    }
}
