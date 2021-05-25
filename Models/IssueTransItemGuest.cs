using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssueTransItemGuest
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransType1 { get; set; }
        public string TransType2 { get; set; }
        public string TransSerial { get; set; }
        public int IssItmSerial { get; set; }
        public int LineSerial { get; set; }
        public int TerminalId { get; set; }
        public string SalesType { get; set; }
        public int ItmSerial { get; set; }
        public string UnitId { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? UnitSalesPrice { get; set; }
        public decimal? DiscountValueForItem { get; set; }
        public int GuestNo { get; set; }
        public int? MixNo { get; set; }
        public int? AddOnsLineSerial { get; set; }
        public decimal? AddOnsUnitSalesPrice { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
