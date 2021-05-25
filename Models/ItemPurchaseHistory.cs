using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemPurchaseHistory
    {
        public int Iphserial { get; set; }
        public string ComCode { get; set; }
        public int ItmSerial { get; set; }
        public int VendorId { get; set; }
        public string Iphyear { get; set; }
        public decimal? IphavgCost { get; set; }
        public decimal? IphavgCustoms { get; set; }
        public decimal? IphavgSales { get; set; }
        public decimal? IphavgOthers { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
    }
}
