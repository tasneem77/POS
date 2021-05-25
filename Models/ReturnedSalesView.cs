using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ReturnedSalesView
    {
        public string StoreName { get; set; }
        public DateTime? TrnsDate { get; set; }
        public int? Year { get; set; }
        public string UserId { get; set; }
        public string TerminalName { get; set; }
        public int? TermCode { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string TransSerial { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? UnitSalesPrice { get; set; }
        public decimal? BeforeDiscountPrice { get; set; }
        public string InsertUid { get; set; }
        public string TransType1 { get; set; }
        public string StoCode { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public DateTime? PostDate { get; set; }
        public string Remarks { get; set; }
        public string OrigSalesTrnsId { get; set; }
        public DateTime? OriginalTrnsDate { get; set; }
        public decimal? OriginalNetAmount { get; set; }
    }
}
