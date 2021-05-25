using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemStoreExpiryDataView
    {
        public string StoCode { get; set; }
        public string StoreName { get; set; }
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItemName2 { get; set; }
        public decimal? Qty { get; set; }
        public string BarCode { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string SalesUnitCode { get; set; }
        public string UnitName { get; set; }
    }
}
