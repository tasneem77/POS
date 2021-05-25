using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PaymentType
    {
        public int PaymentTypeId { get; set; }
        public string PaymentTypeDesc { get; set; }
        public int? PaymentType1 { get; set; }
        public bool? Status { get; set; }
        public string Remarks { get; set; }
        public string AccountCode { get; set; }
        public int? AccountId { get; set; }
        public string CostCenterCode { get; set; }
        public int? CostCenterId { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
