using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SoldItemsAsTransactionView
    {
        public string StoreCode { get; set; }
        public string TerminalId { get; set; }
        public int? ItemSerial { get; set; }
        public int? DocumentType { get; set; }
        public int DocumentSerial { get; set; }
        public DateTime? TransDate { get; set; }
        public double? TrnsQty { get; set; }
        public int? TransType { get; set; }
        public double? UnitCost { get; set; }
        public double? UnitSalesPrice { get; set; }
        public double? PreviousBalance { get; set; }
        public double? NextBalance { get; set; }
        public int? MixNo { get; set; }
        public int? TrnsMonth { get; set; }
        public int? TrnsYear { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
