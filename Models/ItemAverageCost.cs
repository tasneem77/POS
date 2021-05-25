using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemAverageCost
    {
        public int Id { get; set; }
        public int ItmSerial { get; set; }
        public decimal? PrevAverageCost { get; set; }
        public decimal? PrevSalesPrice { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public int? LastPurchaseCurrCode { get; set; }
        public decimal? LastBasePurchasePrice { get; set; }
        public decimal AverageCost { get; set; }
        public decimal? SalesPrice { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Reference { get; set; }
    }
}
