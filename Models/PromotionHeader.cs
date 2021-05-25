using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PromotionHeader
    {
        public int ProSerial { get; set; }
        public string PriceType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string UpdateFlag { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TypeFlag { get; set; }
    }
}
