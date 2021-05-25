using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class InsurancePlanDetail
    {
        public int PlanHeaderId { get; set; }
        public int LineSerial { get; set; }
        public int? RuleType { get; set; }
        public string RuleTypeCode { get; set; }
        public decimal? RulePercent { get; set; }
        public string Remaks { get; set; }
    }
}
