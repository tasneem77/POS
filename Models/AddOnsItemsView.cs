using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class AddOnsItemsView
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public int LevelItemSerial { get; set; }
        public string LevelItemNameL1 { get; set; }
        public string LevelItemNameL2 { get; set; }
        public int? LevelMaxChoice { get; set; }
        public bool? LevelQtyCheck { get; set; }
        public int? LevelMinChoice { get; set; }
        public string LevelQtyCheckDesc { get; set; }
        public int ItemSerialAddOns { get; set; }
        public string AddOnsItemNameL1 { get; set; }
        public string AddOnsItemNameL2 { get; set; }
        public decimal? Qty { get; set; }
        public string AddOnsItemSalesUnitCode { get; set; }
        public string AddOnsItemSalesUnitNameL1 { get; set; }
        public string AddOnsItemSalesUnitNameL2 { get; set; }
        public decimal? Price { get; set; }
    }
}
