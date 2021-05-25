using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class EndOfdayView
    {
        public string NameL1 { get; set; }
        public string ItmCode { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public decimal? ItmQty { get; set; }
        public decimal? ItmValue { get; set; }
        public string GroupName { get; set; }
        public int? ShId { get; set; }
        public int? Nature { get; set; }
        public int? ItmSerial { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StoCode { get; set; }
        public int TermCode { get; set; }
        public string TerminalName { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Credit { get; set; }
        public int? Coupon { get; set; }
        public decimal? OpeningAmount { get; set; }
        public decimal? Visa { get; set; }
        public decimal? Diff { get; set; }
        public decimal CashAmount { get; set; }
        public decimal VisaAmount { get; set; }
        public decimal CouponAmount { get; set; }
        public decimal CreditCustomerAmount { get; set; }
        public decimal PointsAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? ClosingMonthAverageCost { get; set; }
        public decimal? ClosingMonthTotalCost { get; set; }
        public decimal? ClosingPeriodAverageCost { get; set; }
        public decimal? ClosingPeriodTotalCost { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public decimal? TotalDiscountValueForItem { get; set; }
        public decimal? TotalDiscountValueForHeader { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerNameL1 { get; set; }
        public string CustomerNameL2 { get; set; }
        public DateTime? TrnsDate { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string GroupCode { get; set; }
    }
}
