using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class AutoPoVendorItemsView
    {
        public int VenSerial { get; set; }
        public int ItmSerial { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string NameL1 { get; set; }
        public string VendorName { get; set; }
        public decimal? Discount { get; set; }
        public string ItmCode { get; set; }
        public int VedorId { get; set; }
    }
}
