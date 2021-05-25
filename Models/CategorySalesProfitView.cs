using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CategorySalesProfitView
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TotalBeforDiscount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalAfterDiscount { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? Profit { get; set; }
        public decimal? PercentFromTotal { get; set; }
        public int CashSerial { get; set; }
        public DateTime? InsertDate { get; set; }
        public int Id { get; set; }
    }
}
