using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StoreVoucherDetail
    {
        public string VoucherNo { get; set; }
        public int LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string UnitCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? PreviousBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
