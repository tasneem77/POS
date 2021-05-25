using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CustomersDiscount
    {
        public int Id { get; set; }
        public string DiscountLevelName { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public decimal? MinSalesLimit { get; set; }
        public decimal? MaxSalesLimit { get; set; }
        public string Remarks { get; set; }
        public string InsertUid { get; set; }
        public bool? Status { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
