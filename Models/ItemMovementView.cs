using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemMovementView
    {
        public int? ItemSerial { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItemNameL2 { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public string GroupNameL2 { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public string SalesUnitCode { get; set; }
        public string SalesUnitNameL1 { get; set; }
        public string SalesUnitNameL2 { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
        public int? DocumentType { get; set; }
        public string TransactionType { get; set; }
        public string DocumentSerial { get; set; }
        public DateTime? TransDate { get; set; }
        public int? TransType { get; set; }
        public string TransTypeDesc { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? UnitSalesPrice { get; set; }
        public decimal? PrevBalance { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? NextBalance { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string MainStoCode { get; set; }
        public string MainStoreName { get; set; }
    }
}
