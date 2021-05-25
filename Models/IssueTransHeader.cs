using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssueTransHeader
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public int? SaleMid { get; set; }
        public string SalesTrnsId { get; set; }
        public string ReturnTransId { get; set; }
        public int? TransTypeId { get; set; }
        public string TransType1 { get; set; }
        public string TransType2 { get; set; }
        public string IssueType { get; set; }
        public DateTime? TrnsDate { get; set; }
        public string Year { get; set; }
        public int? TableId { get; set; }
        public int? CustomerId { get; set; }
        public string CreditCardNo { get; set; }
        public DateTime? CreditCardExpiry { get; set; }
        public int? DeliveryAddressId { get; set; }
        public string PhoneNo { get; set; }
        public int? NoOfGuests { get; set; }
        public int? GuestNo { get; set; }
        public decimal? OtherCost { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? TotalTaxs { get; set; }
        public int? TotalItems { get; set; }
        public string TerminalId { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public string PostFlag { get; set; }
        public DateTime? PostDate { get; set; }
        public int? ShiftId { get; set; }
        public string Remarks { get; set; }
        public string IssueDropped { get; set; }
        public int? ReturnReasonId { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertUid { get; set; }
        public string TransUserNo { get; set; }
        public string UserId { get; set; }
        public string SalesType { get; set; }
        public string OrigSalesTrnsId { get; set; }
        public string CustomerName { get; set; }
        public string CouponNo { get; set; }
        public int? MarkComId { get; set; }
        public decimal CashAmount { get; set; }
        public decimal VisaAmount { get; set; }
        public decimal CouponAmount { get; set; }
        public decimal? CreditCustomerAmount { get; set; }
        public decimal? ServiceChargeAmount { get; set; }
        public decimal? MinimumChargeAmount { get; set; }
        public decimal? PointsAmount { get; set; }
        public decimal? AdjustmentAmount { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public string Address { get; set; }
        public int? Printed { get; set; }
        public int? CourierId { get; set; }
        public int? DeliveryPaymentType { get; set; }
        public bool? ComplementaryFlag { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? ServiceChargePercent { get; set; }
        public int? DiscountType { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? WithHoldingTax { get; set; }
        public decimal? WithHoldingTaxPercent { get; set; }
        public decimal? TotalItemsDiscount { get; set; }
        public decimal? TaxValue { get; set; }
        public int? TaxType { get; set; }
        public decimal? TotalItemsTaxes { get; set; }
        public decimal? ServiceChargeValue { get; set; }
        public int? ServiceChargeType { get; set; }
        public decimal? DeliveryChargeValue { get; set; }
        public int? DeliveryChargeType { get; set; }
        public string TempTrnsId { get; set; }
    }
}
