using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesOrderDetailsView
    {
        public string TransNo { get; set; }
        public int LineSerial { get; set; }
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItemNameL2 { get; set; }
        public decimal Qty { get; set; }
        public decimal BonusQty { get; set; }
        public decimal? QtyReadyForDelivery { get; set; }
        public decimal? BonusQtyReadyForDelivery { get; set; }
        public decimal? QtyToBeReadyForDelivery { get; set; }
        public decimal? BonusQtyToBeReadyForDelivery { get; set; }
        public decimal DeliveredQty { get; set; }
        public decimal VoidedQty { get; set; }
        public decimal? DeliveredBonusQty { get; set; }
        public decimal? VoidedBonusQty { get; set; }
        public string UnitCode { get; set; }
        public string UnitNameL1 { get; set; }
        public string UnitNameL2 { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? AddOnsUnitPrice { get; set; }
        public decimal? UnitAndAddOnsPrice { get; set; }
        public int DiscountType { get; set; }
        public string DiscountTypeDesc { get; set; }
        public decimal DiscountForItem { get; set; }
        public decimal? DiscountForItemValue { get; set; }
        public int TaxesType { get; set; }
        public string TaxesTypeDesc { get; set; }
        public decimal TaxesForItem { get; set; }
        public decimal? TaxesForItemValue { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? TotalLine { get; set; }
        public decimal ExpensesForItem { get; set; }
        public decimal DiscountValueFromHeader { get; set; }
        public decimal TaxesValueFromHeader { get; set; }
        public decimal ExpensesValueFromHeader { get; set; }
        public decimal? BaseUnitPrice { get; set; }
        public decimal? BaseUnitAndAddOnsPrice { get; set; }
        public decimal? BaseDiscountForItem { get; set; }
        public decimal? BaseDiscountForItemValue { get; set; }
        public decimal? BaseTaxesForItem { get; set; }
        public decimal? BaseTaxesForItemValue { get; set; }
        public decimal? BaseNetPrice { get; set; }
        public decimal? BaseTotalLine { get; set; }
        public decimal AverageCost { get; set; }
        public decimal AverageLandedCost { get; set; }
        public int? MixNo { get; set; }
        public string Notes { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public string ItemSalesDescription { get; set; }
        public int? AddOnsLineSerial { get; set; }
        public decimal? LastSalesPrice { get; set; }
        public decimal? PriceListDefaultPrice { get; set; }
        public decimal? OfferDefaultPrice { get; set; }
    }
}
