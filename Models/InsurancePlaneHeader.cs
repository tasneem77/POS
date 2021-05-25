using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class InsurancePlaneHeader
    {
        public int PlanHeaderId { get; set; }
        public string PlanCode { get; set; }
        public string Description { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public bool? Status { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
