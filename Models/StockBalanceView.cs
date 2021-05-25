using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StockBalanceView
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string NameL1 { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string UnitSize { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public int? ModelId { get; set; }
        public string ModelCode { get; set; }
        public string ModelDescription { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public double? MinQty { get; set; }
        public double? MaxQty { get; set; }
        public double? ReorderQty { get; set; }
        public double? CompanyBalance { get; set; }
        public double? AverageCost { get; set; }
        public double? LastMonthAverageCost { get; set; }
        public double? LastPeriodAverageCost { get; set; }
        public double? LandedCost { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public double? LastSalesPrice { get; set; }
        public string StoCode { get; set; }
        public string StoreName { get; set; }
        public double? CurrentBalance { get; set; }
        public int? PreferedVendor { get; set; }
        public string Picture { get; set; }
    }
}
