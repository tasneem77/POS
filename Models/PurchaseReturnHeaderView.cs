using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseReturnHeaderView
    {
        public string Pirserial { get; set; }
        public int? VendorSerial { get; set; }
        public string VendorNameL1 { get; set; }
        public string VendorNameL2 { get; set; }
        public DateTime? TransDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public decimal? BaseTotalItemsValue { get; set; }
        public decimal? TotalTaxValue { get; set; }
        public decimal? BaseTotalTaxValue { get; set; }
        public decimal? TotalSalesTaxValue { get; set; }
        public decimal? TotalDiscountValue { get; set; }
        public decimal? BaseTotalDiscountValue { get; set; }
        public string PostFlag { get; set; }
        public DateTime? PostingDate { get; set; }
        public string PostedBy { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyNameL1 { get; set; }
        public string CurrencyNameL2 { get; set; }
        public string ComCode { get; set; }
        public string CompanyName1 { get; set; }
        public string CompanyName2 { get; set; }
        public string StoCode { get; set; }
        public string StoName1 { get; set; }
        public string StoName2 { get; set; }
        public decimal TotalQty { get; set; }
        public string Remarks { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? BaseNetAmount { get; set; }
    }
}
