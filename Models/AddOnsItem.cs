using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class AddOnsItem
    {
        public int ItemSerial { get; set; }
        public int LevelId { get; set; }
        public int ItemSerialAddOns { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
    }
}
