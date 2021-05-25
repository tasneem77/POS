using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CostCenter
    {
        public int CostCenterId { get; set; }
        public int? BranchId { get; set; }
        public int? ParentCostCenterId { get; set; }
        public string UserCode { get; set; }
        public string PrimaryName { get; set; }
        public string SecondaryName { get; set; }
        public int? MainSubType { get; set; }
        public int? TreeLevel { get; set; }
        public int? Active { get; set; }
    }
}
