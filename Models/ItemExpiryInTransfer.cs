using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemExpiryInTransfer
    {
        public int? ItmSerial { get; set; }
        public string Reference { get; set; }
        public string ComCode { get; set; }
        public string FromStoCode { get; set; }
        public string ToStoCode { get; set; }
        public int LineSerial { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string BatchNo { get; set; }
        public decimal? Qty { get; set; }
        public string Barcode { get; set; }
    }
}
