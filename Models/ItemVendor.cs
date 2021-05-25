using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemVendor
    {
        public int VenSerial { get; set; }
        public int ItmSerial { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
    }
}
