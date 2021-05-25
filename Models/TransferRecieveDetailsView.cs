using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TransferRecieveDetailsView
    {
        public string Traserial { get; set; }
        public int RecTransSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItemName2 { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public int? ModelId { get; set; }
        public string ModelDescription { get; set; }
        public string TransMeasureUnit { get; set; }
        public string UnitNameL1 { get; set; }
        public string UnitNameL2 { get; set; }
        public decimal? OtherCostValue { get; set; }
        public decimal? TotalQtyCost { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? ItmSalesPrice { get; set; }
        public decimal? TransferQty { get; set; }
        public decimal? NotDeliverQty { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
    }
}
