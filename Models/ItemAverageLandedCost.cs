using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemAverageLandedCost
    {
        public int Id { get; set; }
        public int ItmSerial { get; set; }
        public decimal? PrevAvgLandedCost { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public int? LastPurchaseCurrCode { get; set; }
        public decimal? LastBasePurchasePrice { get; set; }
        public decimal AvgLandedCost { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
