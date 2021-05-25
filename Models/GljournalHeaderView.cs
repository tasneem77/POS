using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class GljournalHeaderView
    {
        public string GltransNo { get; set; }
        public string ComCode { get; set; }
        public string NameL1 { get; set; }
        public int ErpBranchId { get; set; }
        public string ErpBranchPrimaryName { get; set; }
        public string ErpBranchSecondaryName { get; set; }
        public int ErpDepatmentId { get; set; }
        public string ErpDepartmentPrimaryName { get; set; }
        public string ErpDepartmentSecondaryName { get; set; }
        public int ErpJournalTypeId { get; set; }
        public string ErpJournalPrimaryName { get; set; }
        public string ErpJournalSecondaryName { get; set; }
        public int ErpDoceumentTypeId { get; set; }
        public int? ErpCurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ConversionRate { get; set; }
        public DateTime GlDate { get; set; }
        public string JournalHdrDesc { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? PostFlag { get; set; }
        public string PostFlagDesc { get; set; }
        public DateTime? PostDate { get; set; }
        public int? AccountIntegrationId { get; set; }
    }
}
