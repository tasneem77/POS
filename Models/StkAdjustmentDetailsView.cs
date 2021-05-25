using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StkAdjustmentDetailsView
    {
        public int RecTransSerial { get; set; }
        public string StoreName { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransNo { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? TotalQtyCost { get; set; }
        public string ItmInputCode { get; set; }
        public decimal? PreviouseBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public decimal? DiffQty { get; set; }
        public string InsertUid { get; set; }
        public string TransMeasureUnit { get; set; }
        public string StoCode { get; set; }
    }
}
