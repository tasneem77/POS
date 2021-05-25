using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class GljournalDetailsView
    {
        public string GltransNo { get; set; }
        public int LineSerial { get; set; }
        public int FromToType { get; set; }
        public string FromToTypeDesc { get; set; }
        public string FromToCode { get; set; }
        public string FromToDesc { get; set; }
        public string ErpAccountId { get; set; }
        public string ErpAccountCode { get; set; }
        public string AccountPrimaryName { get; set; }
        public string AccountSecondaryName { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public string JournalDtlDesc { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
