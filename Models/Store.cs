using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Store
    {
        public string StoCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public int? Status { get; set; }
        public int? InStockTake { get; set; }
        public int? BranchId { get; set; }
        public int? DepartmentId { get; set; }
        public string Remarks { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
        public string MainSub { get; set; }
        public string MainStoCode { get; set; }
        public string DefaultSalesSubStoCode { get; set; }
        public string DefaultPurchaseSubStoCode { get; set; }
        public string SubTransferStoCode { get; set; }
        public string CurrencyCode { get; set; }
    }
}
