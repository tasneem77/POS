using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public int? BranchId { get; set; }
        public int? ParentAccountId { get; set; }
        public string UserCode { get; set; }
        public string PrimaryName { get; set; }
        public string SecondaryName { get; set; }
        public int? MainSubType { get; set; }
        public int? AccountType { get; set; }
        public int? DebitCreditType { get; set; }
        public int? RestrictedAccount { get; set; }
        public int? CurrenciesId { get; set; }
        public int? TreeLevel { get; set; }
        public int? Active { get; set; }
    }
}
