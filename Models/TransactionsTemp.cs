using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TransactionsTemp
    {
        public int ItemTransId { get; set; }
        public string StoreCode { get; set; }
        public int? ItemSerial { get; set; }
        public int? DocumentType { get; set; }
        public string DocumentSerial { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? TrnsQty { get; set; }
        public int? TransType { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? UnitSalesPrice { get; set; }
        public decimal? PrevBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public int? MixNo { get; set; }
        public int? TrnsMonth { get; set; }
        public int? TrnsYear { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? MainItemSerial { get; set; }
        public int? AddOnsLineSerial { get; set; }
        public string MainStoCode { get; set; }
    }
}
