using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ShiftsDay
    {
        public string DayCode { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public DateTime? StartTime { get; set; }
        public string StartUserCode { get; set; }
        public DateTime? EndTime { get; set; }
        public string EndUserCode { get; set; }
    }
}
