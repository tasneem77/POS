using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseOrderDetailsView
    {
        public string Poserial { get; set; }
        public int PodlineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public decimal? Podqty { get; set; }
        public decimal ReceivedQty { get; set; }
        public string PodpurchaseUnit { get; set; }
        public string UnitName { get; set; }
        public string UnitName2 { get; set; }
        public decimal? PodpurchasePrice { get; set; }
        public decimal? PodpurchaseBasePrice { get; set; }
        public decimal? PodtotalLine { get; set; }
        public decimal? PodtotalBaseLine { get; set; }
        public decimal? PodlastPurchasePrice { get; set; }
        public int? Podreceived { get; set; }
        public string LineStatus { get; set; }
    }
}
