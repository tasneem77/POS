using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class BillTransHeaderView
    {
        public string StoreName1 { get; set; }
        public string StoreName2 { get; set; }
        public string CompanyName1 { get; set; }
        public string CompanyName2 { get; set; }
        public string CurrencyName1 { get; set; }
        public string CurrencyName2 { get; set; }
        public string VendorName1 { get; set; }
        public string VendorName2 { get; set; }
        public string Sympol { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransNo { get; set; }
        public int? VendorSerial { get; set; }
        public DateTime? TransDate { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? TotalTaxValue { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? TotalDiscountValue { get; set; }
        public decimal? PaidAmount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime? PostingDate { get; set; }
        public string Remarks { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? BaseNetAmount { get; set; }
        public decimal? BasePaidAmount { get; set; }
        public decimal? BaseTotalDiscountValue { get; set; }
        public decimal? BaseTotalValue { get; set; }
        public decimal? BaseTotalTaxValue { get; set; }
        public decimal? BaseTotalOthersValue { get; set; }
        public string PostFlag { get; set; }
        public int? Year { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public string RelatedToInvoice { get; set; }
    }
}
