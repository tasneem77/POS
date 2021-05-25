using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseRequestDetail
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string Prserial { get; set; }
        public int PrdlineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public decimal? Prdqty { get; set; }
        public string PrditmUnitCode { get; set; }
        public decimal? PrdunitFactor { get; set; }
        public decimal? PrtotalQtyInSmallUnit { get; set; }
        public string Prdremarks { get; set; }
        public int Prdyear { get; set; }
        public decimal? PrCurrentBalance { get; set; }
        public DateTime? PrdinsertDate { get; set; }
        public string PrdupdateUid { get; set; }
        public DateTime? PrdupdateDate { get; set; }
        public string PrdinsertUid { get; set; }
        public decimal? PrdretunrQty { get; set; }
        public int? Prdstatus { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public decimal? PrunitPrice { get; set; }
    }
}
