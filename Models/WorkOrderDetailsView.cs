using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class WorkOrderDetailsView
    {
        public string TransNo { get; set; }
        public int? LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItemNameL2 { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public decimal? TransQty { get; set; }
        public string InsertUid { get; set; }
        public string UnitCode { get; set; }
        public string UnitNameL1 { get; set; }
        public string UnitNameL2 { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
