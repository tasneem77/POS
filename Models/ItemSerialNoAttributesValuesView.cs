using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSerialNoAttributesValuesView
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemNameL1 { get; set; }
        public string SerialNo { get; set; }
        public string StoCode { get; set; }
        public string ComCode { get; set; }
        public bool? AvailabilityInStock { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}
