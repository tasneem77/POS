using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class GljournalsHeader
    {
        public string GltransNo { get; set; }
        public string ComCode { get; set; }
        public int ErpBranchId { get; set; }
        public int ErpDepatmentId { get; set; }
        public int ErpJournalTypeId { get; set; }
        public int ErpDoceumentTypeId { get; set; }
        public int? ErpCurrencyId { get; set; }
        public decimal? ConversionRate { get; set; }
        public DateTime GlDate { get; set; }
        public string JournalHdrDesc { get; set; }
        public int? AccountIntegrationId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public int? PostFlag { get; set; }
        public DateTime? PostDate { get; set; }
    }
}
