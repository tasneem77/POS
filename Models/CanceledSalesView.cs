using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CanceledSalesView
    {
        public DateTime? TrnsDate { get; set; }
        public string Year { get; set; }
        public string UserId { get; set; }
        public string ItmCode { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ItemName { get; set; }
        public string TransSerial { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? UnitSalesPrice { get; set; }
        public decimal? ItemTotal { get; set; }
        public decimal? BeforeDiscountPrice { get; set; }
        public string InsertUid { get; set; }
        public string TransType1 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? NetAmount { get; set; }
        public string TerminalId { get; set; }
        public string SalesTrnsId { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
    }
}
