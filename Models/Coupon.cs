using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Coupon
    {
        public string CouponId { get; set; }
        public string CouponType { get; set; }
        public decimal CouponValue { get; set; }
        public string CouponFlag { get; set; }
        public string UsedTransNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public int MarkComId { get; set; }
        public int PeriodId { get; set; }
        public int? UsedTransTerminalId { get; set; }
        public string UsedTransStoCode { get; set; }
        public string SoldTransNo { get; set; }
        public int? SoldTransTerminalId { get; set; }
        public string SoldTransStoCode { get; set; }
    }
}
