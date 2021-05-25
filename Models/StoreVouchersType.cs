using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StoreVouchersType
    {
        public int VoucherTypeId { get; set; }
        public string VoucherTypeCode { get; set; }
        public string VoucherType { get; set; }
        public int? TransactionType { get; set; }
        public int? Status { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string AccountCode { get; set; }
        public int? AccountId { get; set; }
        public string CostCenterCode { get; set; }
        public int? CostCenterId { get; set; }
    }
}
