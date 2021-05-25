using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class GljournalsDetail
    {
        public string GltransNo { get; set; }
        public int LineSerial { get; set; }
        public string ComCode { get; set; }
        public int FromToType { get; set; }
        public string FromToCode { get; set; }
        public string ErpAccountId { get; set; }
        public string ErpAccountCode { get; set; }
        public string DebitCredit { get; set; }
        public decimal Amount { get; set; }
        public string JournalDtlDesc { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
    }
}
