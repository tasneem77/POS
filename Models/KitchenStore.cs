using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class KitchenStore
    {
        public int KitchenId { get; set; }
        public string IssueStoCode { get; set; }
        public string StockStoCode { get; set; }
    }
}
