using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PriceListDetail
    {
        public string PriceListCode { get; set; }
        public int LineSerial { get; set; }
        public int ItmSerial { get; set; }
        public decimal Qty { get; set; }
        public string UnitType { get; set; }
        public decimal? Price { get; set; }
        public decimal? MinPrice { get; set; }
        public int? DiscountType { get; set; }
        public decimal? Discount { get; set; }
        public int? TaxType { get; set; }
        public decimal? Tax { get; set; }
        public DateTime ApplyPriceDate { get; set; }
        public bool Status { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
