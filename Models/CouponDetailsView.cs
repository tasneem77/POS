using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CouponDetailsView
    {
        public int CouponId { get; set; }
        public string CouponTypeDesc { get; set; }
        public decimal CouponValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MarkComId { get; set; }
        public string CouponDesc { get; set; }
        public string UsedTransNo { get; set; }
        public int? UsedTransTerminalId { get; set; }
        public string UsedTerminalName { get; set; }
        public string UsedTransStoCode { get; set; }
        public string UsedStoreName { get; set; }
        public DateTime DateUsed { get; set; }
        public string SoldTransNo { get; set; }
        public int? SoldTransTerminalId { get; set; }
        public string SoldTerminalName { get; set; }
        public string SoldTransStoCode { get; set; }
        public string SoldStoreName { get; set; }
        public DateTime DateSold { get; set; }
        public bool? CouponFlag { get; set; }
        public decimal? CouponAmount { get; set; }
    }
}
