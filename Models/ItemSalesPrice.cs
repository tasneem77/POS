using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSalesPrice
    {
        public int Ispserial { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string PriceType { get; set; }
        public int? ItmSerial { get; set; }
        public DateTime? ApplyPriceDate { get; set; }
        public decimal? Price { get; set; }
        public int Remarks { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Value { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountValue { get; set; }
        public string PriceFactor { get; set; }
        public decimal? SalesTax2 { get; set; }
        public int? Flag { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
        public string ReferenceNo { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDatetime { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDatetime { get; set; }

        public virtual ItemMaster ItmSerialNavigation { get; set; }
    }
}
