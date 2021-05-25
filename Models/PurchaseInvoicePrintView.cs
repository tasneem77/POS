using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseInvoicePrintView
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
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public int? ModelId { get; set; }
        public string ModelDescription { get; set; }
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
        public int? ItmSerial { get; set; }
        public string BatchNo { get; set; }
        public string ExpiryDate { get; set; }
        public decimal? BonusQty { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? BaseNetAmount { get; set; }
        public decimal? BaseTotalDiscountValue { get; set; }
        public decimal? BaseTotalItemsValue { get; set; }
        public decimal? BaseTotalOthersValue { get; set; }
        public decimal? ItmSalesPrice { get; set; }
        public decimal? ExpensesValuePerQty { get; set; }
        public string MainVendorCode { get; set; }
        public string MainVendorName { get; set; }
    }
}
