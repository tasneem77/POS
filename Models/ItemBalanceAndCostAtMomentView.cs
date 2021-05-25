using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemBalanceAndCostAtMomentView
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string SalesUnitNameL1 { get; set; }
        public int Balance { get; set; }
        public int AvgCost { get; set; }
        public int? TotalCost { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
    }
}
