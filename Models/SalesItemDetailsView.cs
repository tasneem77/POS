using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesItemDetailsView
    {
        public string StoCode { get; set; }
        public string TransType2 { get; set; }
        public string SalesType { get; set; }
        public string TransSerial { get; set; }
        public string UnitId { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? UnitSalesPrice { get; set; }
        public string Year { get; set; }
        public int? SalesManSerial { get; set; }
        public int IssItmSerial { get; set; }
        public string SalesMan { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string UnitName { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string StoreName { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? BeforeDiscountPrice { get; set; }
        public decimal? DiscountValueForItem { get; set; }
        public decimal? DiscountValueForHeader { get; set; }
        public decimal? TotalAfterDiscount { get; set; }
        public decimal? TotalBeforDiscount { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? Profit { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? Month { get; set; }
        public string TransType1 { get; set; }
        public string PostFlag { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
    }
}
