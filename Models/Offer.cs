using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Offer
    {
        public int OfferId { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Price { get; set; }
        public decimal? OfferQty { get; set; }
        public bool? Status { get; set; }
        public string InsertUid { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
