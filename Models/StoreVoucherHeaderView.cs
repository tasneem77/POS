using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StoreVoucherHeaderView
    {
        public string VoucherNo { get; set; }
        public int? TransactionType { get; set; }
        public string VoucherDesc { get; set; }
        public int? VoucherTypeId { get; set; }
        public string VoucherTypeCode { get; set; }
        public string VoucherType { get; set; }
        public DateTime? TransDate { get; set; }
        public string StoCode { get; set; }
        public string StoreNameL1 { get; set; }
        public string StoreNameL2 { get; set; }
        public int? BeneficiaryType { get; set; }
        public string BeneficiaryTypeDesc { get; set; }
        public string BeneficiaryCode { get; set; }
        public string BeneficiaryDesc { get; set; }
        public string BeneficiaryRemarks { get; set; }
        public string Remarks { get; set; }
        public int? PostFlag { get; set; }
        public string PostFlagDesc { get; set; }
        public DateTime? PostDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal TotalCost { get; set; }
        public string BeneficiaryDetailCode { get; set; }
        public string PostedBy { get; set; }
    }
}
