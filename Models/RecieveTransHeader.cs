using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RecieveTransHeader
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public string TransNo { get; set; }
        public string ReTransTypeCodeLevel1 { get; set; }
        public string ReTransTypeCodeLevel2 { get; set; }
        public int? ReTransNo { get; set; }
        public int? VendorSerial { get; set; }
        public int? Year { get; set; }
        public DateTime? TransDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? TotalTaxValue { get; set; }
        public decimal? TotalSalesTaxValue { get; set; }
        public decimal? TotalDiscountValue { get; set; }
        public decimal? TotalCustomsValue { get; set; }
        public decimal? TotalOthersValue { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public decimal? PaidAmount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PostFlag { get; set; }
        public DateTime? PostingDate { get; set; }
        public string ReturnStoreCode { get; set; }
        public int? RecievedFlag { get; set; }
        public string Remarks { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public string OrigTransNo { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? BaseNetAmount { get; set; }
        public decimal? BasePaidAmount { get; set; }
        public decimal? BaseTotalDiscountValue { get; set; }
        public decimal? BaseTotalItemsValue { get; set; }
        public decimal? BaseTotalTaxValue { get; set; }
        public decimal? BaseTotalOthersValue { get; set; }
        public decimal? ReferenceTotal { get; set; }
    }
}
