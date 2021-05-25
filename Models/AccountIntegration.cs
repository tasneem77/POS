using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class AccountIntegration
    {
        public int Id { get; set; }
        public decimal? DepartmentId { get; set; }
        public decimal? DocumentTypesId { get; set; }
        public string JournalNo { get; set; }
        public DateTime? JournalDate { get; set; }
        public decimal? JournalTypesId { get; set; }
        public string JournalHdrDesc { get; set; }
        public decimal LineNo { get; set; }
        public decimal? AccountId { get; set; }
        public decimal? CurrenciesId { get; set; }
        public decimal? ConversionRate { get; set; }
        public string DebitCreditMarker { get; set; }
        public decimal? AmountFc { get; set; }
        public string JournalDtlDesc { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? CostCenterId { get; set; }
        public decimal? PostedDocumentId { get; set; }
        public string CihostSerial { get; set; }
        public decimal? CihostType { get; set; }
        public string SetlFor { get; set; }
        public string SetlRef { get; set; }
        public int? BankId { get; set; }
        public string CheckNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public string TransNo { get; set; }
        public int? JournalType { get; set; }
        public int? LineType { get; set; }
    }
}
