using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Department
    {
        public Department()
        {
            PurchaseRequestHeaders = new HashSet<PurchaseRequestHeader>();
        }

        public int Id { get; set; }
        public string DeptCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public bool Status { get; set; }
        public int? BranchId { get; set; }
        public string StoreCode { get; set; }
        public int? PrinterId { get; set; }
        public string Notes { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<PurchaseRequestHeader> PurchaseRequestHeaders { get; set; }
    }
}
