using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesHeaderView
    {
        public string StoCode { get; set; }
        public string StoreName { get; set; }
        public string SalesTrnsId { get; set; }
        public DateTime? TrnsDate { get; set; }
        public string TransType1 { get; set; }
        public string TransType2 { get; set; }
        public string SalesType { get; set; }
        public string SalesTypeDesc { get; set; }
        public string PostFlag { get; set; }
        public string ReceiptStatus { get; set; }
        public string IssueType { get; set; }
        public decimal? TotalTaxs { get; set; }
        public decimal? ServiceChargeAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public int? TotalItems { get; set; }
        public string TerminalId { get; set; }
        public string TerminalName { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal? TotalRemainningAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal VisaAmount { get; set; }
        public decimal CouponAmount { get; set; }
        public decimal? CreditCustomerAmount { get; set; }
        public decimal? PointsAmount { get; set; }
        public int? ShiftId { get; set; }
        public int? SaleMid { get; set; }
        public string SalesMan { get; set; }
        public DateTime? PostDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Remarks { get; set; }
        public int? CustomerId { get; set; }
        public string PhoneNo { get; set; }
        public string NameL1 { get; set; }
        public int? AreaSerial { get; set; }
        public string Area { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public int? CourierId { get; set; }
        public string CourierName { get; set; }
        public DateTime? ShiftStartDate { get; set; }
        public DateTime? ShiftEndDate { get; set; }
        public bool? ComplementaryFlag { get; set; }
        public string RebateTypeDesc { get; set; }
        public decimal? Rebate { get; set; }
        public decimal? RebateValue { get; set; }
        public decimal? TotalAmountAfterRebate { get; set; }
    }
}
