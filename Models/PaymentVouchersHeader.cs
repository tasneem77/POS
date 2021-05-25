using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PaymentVouchersHeader
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransNo { get; set; }
        public DateTime? TransDate { get; set; }
        public int? TransType { get; set; }
        public int? BeneficiaryType { get; set; }
        public string BeneficiaryId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrencyXrate { get; set; }
        public decimal? TotalAmountinBase { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? PostFlag { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? MainSub { get; set; }
        public string Remarks { get; set; }
        public string AccountCode { get; set; }
        public int? AccountId { get; set; }
        public string CostCenterCode { get; set; }
        public int? CostCenterId { get; set; }
        public string DocumentNo { get; set; }
        public int? SalesManId { get; set; }
    }
}
