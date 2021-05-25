using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ViewItem
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string NameL1 { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public decimal? LastSalesPrice { get; set; }
    }
}
