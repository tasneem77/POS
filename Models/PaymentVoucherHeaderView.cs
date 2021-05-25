using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PaymentVoucherHeaderView
    {
        public string ComCode { get; set; }
        public string CompanyName { get; set; }
        public string StoCode { get; set; }
        public string StoreName { get; set; }
        public string TransNo { get; set; }
        public DateTime? TransDate { get; set; }
        public int? TransType { get; set; }
        public string TransTypeDesc { get; set; }
        public int? BeneficiaryType { get; set; }
        public string BeneficiaryDesc { get; set; }
        public string BeneficiaryId { get; set; }
        public string BeneficiaryName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal? CurrencyXrate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalAmountinBase { get; set; }
        public int? PostFlag { get; set; }
        public string PostFlagDesc { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Remarks { get; set; }
        public string AccountCode { get; set; }
        public int? AccountId { get; set; }
        public string CostCenterCode { get; set; }
        public int? CostCenterId { get; set; }
        public string DocumentNo { get; set; }
        public int? SalesManId { get; set; }
        public string SalesMan { get; set; }
        public string MainSub { get; set; }
    }
}
