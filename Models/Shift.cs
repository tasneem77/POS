using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Shift
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public string UserCode { get; set; }
        public int? ShiftFlag { get; set; }
        public DateTime? EndDate { get; set; }
        public int CashSerial { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Visa { get; set; }
        public decimal? Diff { get; set; }
        public string NewStartUserCode { get; set; }
        public decimal? Custody { get; set; }
        public decimal? ReturnValue { get; set; }
        public int? CouponCount { get; set; }
        public decimal? Payout { get; set; }
        public string DayCode { get; set; }
    }
}
