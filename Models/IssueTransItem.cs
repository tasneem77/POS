using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssueTransItem
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransType1 { get; set; }
        public string TransType2 { get; set; }
        public string TransSerial { get; set; }
        public int IssItmSerial { get; set; }
        public string UnitId { get; set; }
        public int? ItmSerial { get; set; }
        public int? MixNo { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? UnitSalesPrice { get; set; }
        public decimal? DiscountValueForItem { get; set; }
        public decimal? DiscountValueForHeader { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? SalestaxValue { get; set; }
        public string Remarks { get; set; }
        public string Year { get; set; }
        public int? GuestNo { get; set; }
        public int? TableId { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string SalesManSerial { get; set; }
        public string PriceFlag { get; set; }
        public decimal? BeforeDiscountPrice { get; set; }
        public decimal? PrevBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public int? KitchenId { get; set; }
        public int? Printed { get; set; }
        public int? CategoryId { get; set; }
        public string TerminalId { get; set; }
        public string SalesType { get; set; }
        public int? AddOnsLineSerial { get; set; }
        public decimal? AddOnsUnitPrice { get; set; }
        public string Notes { get; set; }
        public string UnitType { get; set; }
        public int? OfferId { get; set; }
        public int? VoidIssItmSerial { get; set; }
        public decimal? DiscountItemValue { get; set; }
        public int? DiscountItemType { get; set; }
        public decimal? TaxValue { get; set; }
        public int? TaxType { get; set; }
        public decimal? ServiceChargeFromHeader { get; set; }
        public decimal? DeliveryChargeFromHeader { get; set; }
        public decimal? TaxFromHeader { get; set; }
        public decimal? WithHoldingTaxFromHeader { get; set; }
        public string VoidReason { get; set; }
    }
}
