using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class BarcodePrint
    {
        public int Serial { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal? ItemSalesPrice { get; set; }
        public int? NoOfCopy { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string BatchNo { get; set; }
    }
}
