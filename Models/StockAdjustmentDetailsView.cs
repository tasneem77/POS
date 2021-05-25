using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StockAdjustmentDetailsView
    {
        public string Stkserial { get; set; }
        public int RecTransSerial { get; set; }
        public int? LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public decimal? PreviouseBalance { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? NextBalance { get; set; }
        public decimal? DiffQty { get; set; }
        public string InsertUid { get; set; }
        public string TransMeasureUnit { get; set; }
        public string UnitNameL1 { get; set; }
        public string UnitNameL2 { get; set; }
        public decimal? OtherCostValue { get; set; }
        public decimal? TotalQtyCost { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public string StockAdjustmentTypeDesc { get; set; }
    }
}
