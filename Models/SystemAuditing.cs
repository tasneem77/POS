using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SystemAuditing
    {
        public string AuditNo { get; set; }
        public string StoCode { get; set; }
        public int? TerminalId { get; set; }
        public string UserId { get; set; }
        public string FormName { get; set; }
        public DateTime? AuditingDatetime { get; set; }
        public int? AuditType { get; set; }
        public int? ReferenceType { get; set; }
        public string ReferenceNo { get; set; }
        public string PrimaryKey { get; set; }
        public string Remarks { get; set; }
    }
}
