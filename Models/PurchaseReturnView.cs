using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseReturnView
    {
        public string TransNo { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string NameL1 { get; set; }
        public DateTime? TransDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? TotalTaxValue { get; set; }
        public decimal? TotalSalesTaxValue { get; set; }
        public decimal? TotalDiscountValue { get; set; }
        public string PostFlag { get; set; }
        public DateTime? PostingDate { get; set; }
        public string PostedBy { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? TransUnitPrice { get; set; }
        public decimal? ItemDiscountValue { get; set; }
        public decimal? DocumentDiscountValue { get; set; }
        public decimal? TransItmTaxValue { get; set; }
        public decimal? TransSalesTaxValue { get; set; }
        public decimal? TotalQtyPrice { get; set; }
        public string ItmInputCode { get; set; }
        public string StoreName { get; set; }
        public string UnitName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
    }
}
