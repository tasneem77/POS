using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string ComCode { get; set; }
        public int? CompanyAccountId { get; set; }
        public string CompanyAccountCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Pobox { get; set; }
        public string CurrencyCode { get; set; }
        public string DefaultPurchaseCurrency { get; set; }
        public string WebSite { get; set; }
        public string CompanyEmail { get; set; }
        public bool? Status { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
        public int? IntegrationCode { get; set; }
        public int? ErpBranchId { get; set; }
        public bool? UseTax { get; set; }
        public bool? UseServiceCharge { get; set; }
        public bool? UseMinimumCharge { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? ServiceChargePercent { get; set; }
        public decimal? MinimumChargeValue { get; set; }
        public string SuffixCode { get; set; }
        public string TransferStoCode { get; set; }
        public string ProductionStoCode { get; set; }
    }
}
