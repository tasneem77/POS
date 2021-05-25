using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseOrderDetail
    {
        public string ComCode { get; set; }
        public string Poserial { get; set; }
        public int PodlineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public DateTime? PoddeliveryDate { get; set; }
        public decimal? Podqty { get; set; }
        public int? PodvendorSerial { get; set; }
        public decimal? PodpurchasePrice { get; set; }
        public decimal? PodpurchaseBasePrice { get; set; }
        public decimal? PodlastPurchasePrice { get; set; }
        public decimal? PodreceivedQty { get; set; }
        public decimal? PodreturnQty { get; set; }
        public decimal? PodtotalLine { get; set; }
        public decimal? PodtotalBaseLine { get; set; }
        public string Podremarks { get; set; }
        public int? Podyear { get; set; }
        public DateTime? PodinsertDate { get; set; }
        public string PodupdateUid { get; set; }
        public DateTime? PodupdateDate { get; set; }
        public string PodinsertUid { get; set; }
        public decimal? ItmSalesPrice { get; set; }
        public string PodpurchaseUnit { get; set; }
        public decimal? PodunitFactor { get; set; }
        public int? Podreceived { get; set; }
        public decimal? BonusQty { get; set; }
        public decimal? ItemDiscount { get; set; }
    }
}
