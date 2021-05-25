using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesOrderDetail
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public string TransNo { get; set; }
        public int LineSerial { get; set; }
        public int ItmSerial { get; set; }
        public decimal Qty { get; set; }
        public string UnitCode { get; set; }
        public decimal UnitPrice { get; set; }
        public int DiscountType { get; set; }
        public decimal DiscountForItem { get; set; }
        public decimal DiscountValueFromHeader { get; set; }
        public int TaxesType { get; set; }
        public decimal TaxesForItem { get; set; }
        public decimal TaxesValueFromHeader { get; set; }
        public decimal ExpensesForItem { get; set; }
        public decimal ExpensesValueFromHeader { get; set; }
        public decimal BonusQty { get; set; }
        public decimal AverageCost { get; set; }
        public decimal AverageLandedCost { get; set; }
        public int? MixNo { get; set; }
        public decimal DeliveredQty { get; set; }
        public decimal VoidedQty { get; set; }
        public int? Version { get; set; }
        public string Notes { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal? DeliveredBonusQty { get; set; }
        public decimal? VoidedBonusQty { get; set; }
        public string ItemSalesDescription { get; set; }
        public decimal? AddOnsUnitPrice { get; set; }
        public int? AddOnsLineSerial { get; set; }
        public decimal? QtyReadyForDelivery { get; set; }
        public decimal? BonusQtyReadyForDelivery { get; set; }
    }
}
