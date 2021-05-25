using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PromotionDetail
    {
        public int ProSerial { get; set; }
        public string ComCode { get; set; }
        public int? ItmSerial { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? QtyDiscountLimit { get; set; }
        public decimal? ValueDiscountLimit { get; set; }
        public string UpdateFlag { get; set; }

        public virtual ItemMaster ItmSerialNavigation { get; set; }
    }
}
