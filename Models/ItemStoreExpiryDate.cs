using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemStoreExpiryDate
    {
        public int ItmSerial { get; set; }
        public string StoCode { get; set; }
        public string ComCode { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int BatchId { get; set; }
        public string BatchNo { get; set; }
        public decimal? Qty { get; set; }
        public string BarCode { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
    }
}
