using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesOrderHeader
    {
        public string TransNo { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public int? CustomerId { get; set; }
        public int? Year { get; set; }
        public DateTime TransDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalLandedCost { get; set; }
        public string CurrencyCode { get; set; }
        public decimal GrossAmount { get; set; }
        public int DiscountType { get; set; }
        public decimal Discount { get; set; }
        public int TaxesType { get; set; }
        public decimal Taxes { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal NetAmount { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal BaseGrossAmount { get; set; }
        public decimal BaseDiscount { get; set; }
        public decimal BaseTaxes { get; set; }
        public decimal BaseTotalExpenses { get; set; }
        public decimal BaseNetAmount { get; set; }
        public int Status { get; set; }
        public int? SalesManId { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string OrigTransNo { get; set; }
        public string OrigTransTypeCodeLevel1 { get; set; }
        public string OrigTransTypeCodeLevel2 { get; set; }
        public string Pono { get; set; }
        public DateTime? Podate { get; set; }
        public string Remarks { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? DeliveredDateTime { get; set; }
        public bool? Printed { get; set; }
        public int? RebateType { get; set; }
        public decimal? Rebate { get; set; }
        public decimal? TotalAmountAfterRebate { get; set; }
        public decimal? BaseRebate { get; set; }
        public decimal? BaseTotalAmountAfterRebate { get; set; }
    }
}
