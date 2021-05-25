using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemStoreSerialNo
    {
        public int ItmSerial { get; set; }
        public string StoCode { get; set; }
        public string ComCode { get; set; }
        public string SerialNo { get; set; }
        public bool? AvailabilityInStock { get; set; }
        public decimal? UnitCost { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}
