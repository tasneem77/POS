using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Kitchen
    {
        public int KitchenId { get; set; }
        public string KitchenName { get; set; }
        public string PrinterName { get; set; }
        public int? OrderDisplay { get; set; }
        public bool? UseExternalStockStore { get; set; }
    }
}
