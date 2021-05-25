using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ReceivingItemsTempCollector
    {
        public int Id { get; set; }
        public string TransNo { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public string StoCode { get; set; }
        public string UserCode { get; set; }
        public string BarCode { get; set; }
        public int? ItmSerial { get; set; }
        public decimal? Qty { get; set; }
        public int? UnitCode { get; set; }
        public string OriginalTransNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string BatchNo { get; set; }
    }
}
