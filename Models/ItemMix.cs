using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemMix
    {
        public int MixNo { get; set; }
        public int ItmSerial { get; set; }
        public int ItmSerial1 { get; set; }
        public decimal? ItmQty { get; set; }
        public decimal? ItmPrice { get; set; }
        public decimal? ItmCost { get; set; }
        public decimal? ItmTotalCost { get; set; }
        public string UnitType { get; set; }
    }
}
