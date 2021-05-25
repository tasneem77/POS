using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesOrderHeaderView
    {
        public string TransNo { get; set; }
        public DateTime TransDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalLandedCost { get; set; }
        public int Status { get; set; }
        public string StatusDesc { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public int? Year { get; set; }
        public string ComCode { get; set; }
        public string CompanyName1 { get; set; }
        public string CompanyName2 { get; set; }
        public string StoCode { get; set; }
        public string StoName1 { get; set; }
        public string StoName2 { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyNameL1 { get; set; }
        public string CurrencyNameL2 { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal ExchangeRate { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string BaseCurrencyNameL1 { get; set; }
        public string BaseCurrencyNameL2 { get; set; }
        public string BaseCurrencySymbol { get; set; }
        public decimal GrossAmount { get; set; }
        public int DiscountType { get; set; }
        public string DiscountTypeDesc { get; set; }
        public decimal Discount { get; set; }
        public decimal? DiscountValue { get; set; }
        public string TaxesTypeDesc { get; set; }
        public decimal Taxes { get; set; }
        public decimal? TaxesValue { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal NetAmount { get; set; }
        public string RebateTypeDesc { get; set; }
        public decimal Rebate { get; set; }
        public decimal? RebateValue { get; set; }
        public decimal? TotalAmountAfterRebate { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalReturnedAmount { get; set; }
        public decimal? TotalRemainningAmount { get; set; }
        public decimal BaseGrossAmount { get; set; }
        public decimal BaseDiscount { get; set; }
        public decimal? BaseDiscountValue { get; set; }
        public decimal BaseTaxes { get; set; }
        public decimal? BaseTaxesValue { get; set; }
        public decimal BaseTotalExpenses { get; set; }
        public decimal BaseNetAmount { get; set; }
        public decimal BaseRebate { get; set; }
        public decimal? BaseRebateValue { get; set; }
        public decimal BaseTotalAmountAfterRebate { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerNameL1 { get; set; }
        public string CustomerNameL2 { get; set; }
        public string PhoneNo { get; set; }
        public string ContactPerson { get; set; }
        public decimal? CreditLimit { get; set; }
        public string CreditPeriod { get; set; }
        public int? PaymentDays { get; set; }
        public string CommercialRegistrationNo { get; set; }
        public DateTime? CommercialRegistrationExpireDate { get; set; }
        public string MunicipalityApprovalNo { get; set; }
        public DateTime? MunicipalityApprovalExpireDate { get; set; }
        public string SponserId { get; set; }
        public DateTime? SponsorIdexpireDate { get; set; }
        public string Nationality { get; set; }
        public string MailAddress { get; set; }
        public string Pobox { get; set; }
        public string Remarks { get; set; }
        public int? SalesManId { get; set; }
        public string SaleManNameL1 { get; set; }
        public string SaleManNameL2 { get; set; }
        public string OrigTransNo { get; set; }
        public string OrigTransTypeCodeLevel1 { get; set; }
        public string OrigTransTypeCodeLevel1Desc { get; set; }
        public string OrigTransTypeCodeLevel2 { get; set; }
        public string OrigTransTypeCodeLevel2Desc { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public string Pono { get; set; }
        public DateTime? Podate { get; set; }
        public DateTime? DeliveredDateTime { get; set; }
        public bool? Printed { get; set; }
        public bool? ReadyForDeliveryStatus { get; set; }
        public bool? DeliveryStatus { get; set; }
        public string PostedBy { get; set; }
        public string InvoicedBy { get; set; }
        public string InvoicedDateTime { get; set; }
        public string CanceledBy { get; set; }
        public string CanceledDateTime { get; set; }
    }
}
