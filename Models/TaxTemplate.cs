using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TaxTemplate
    {
        public decimal Id { get; set; }
        public string TaxTcode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public int? Type { get; set; }
        public int? DepartmentId { get; set; }
        public int Status { get; set; }
        public decimal? Rate { get; set; }
        public int? Round { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }

        public virtual TaxType TypeNavigation { get; set; }
    }
}
