using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StoreVoucherHeader
    {
        public string VoucherNo { get; set; }
        public int? TransactionType { get; set; }
        public int? VoucherTypeId { get; set; }
        public DateTime? TransDate { get; set; }
        public string StoCode { get; set; }
        public int? BeneficiaryType { get; set; }
        public string BeneficiaryCode { get; set; }
        public string BeneficiaryRemarks { get; set; }
        public string Remarks { get; set; }
        public int? PostFlag { get; set; }
        public DateTime? PostDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
