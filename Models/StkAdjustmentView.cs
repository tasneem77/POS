using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StkAdjustmentView
    {
        public string TransNo { get; set; }
        public int RecTransSerial { get; set; }
        public string StoCode { get; set; }
        public string StoreName { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public decimal? PreviouseBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public decimal? DifferenceBalance { get; set; }
        public string TransMeasureUnit { get; set; }
        public string UnitName { get; set; }
        public decimal? OtherCostValue { get; set; }
        public decimal? TotalQtyCost { get; set; }
    }
}
