using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class HourlySalesReportView
    {
        public DateTime? Date { get; set; }
        public string Hour { get; set; }
        public decimal? Total { get; set; }
        public int? NoOfBills { get; set; }
        public decimal? Avgbill { get; set; }
        public string StoCode { get; set; }
        public int? TotalAway { get; set; }
        public decimal? AwayRevenue { get; set; }
        public decimal? DineRevenue { get; set; }
        public int? TotalDineIn { get; set; }
    }
}
