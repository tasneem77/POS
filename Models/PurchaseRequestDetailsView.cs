using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseRequestDetailsView
    {
        public string ComCode { get; set; }
        public string ComName1 { get; set; }
        public string ComName2 { get; set; }
        public string StoCode { get; set; }
        public string StoName1 { get; set; }
        public string StoName2 { get; set; }
        public string Prserial { get; set; }
        public int PrdlineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItemNameL2 { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public decimal? Prdqty { get; set; }
        public decimal? PrdretunrQty { get; set; }
        public string PrditmUnitCode { get; set; }
        public string PrdunitName1 { get; set; }
        public string PrdunitName2 { get; set; }
        public decimal? PrdunitFactor { get; set; }
        public decimal? PrtotalQtyInSmallUnit { get; set; }
        public string Prdremarks { get; set; }
        public int Prdyear { get; set; }
        public decimal? PrCurrentBalance { get; set; }
        public int? Prdstatus { get; set; }
        public string PrdstatusDesc { get; set; }
        public DateTime? PrdinsertDate { get; set; }
        public string PrdinsertUid { get; set; }
        public DateTime? PrdupdateDate { get; set; }
        public string PrdupdateUid { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public decimal? PrunitPrice { get; set; }
    }
}
