using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Attendance
    {
        public int TrnsId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public int? TransactionType { get; set; }
        public int? TerminalId { get; set; }
        public string StoCode { get; set; }
        public string InsertUid { get; set; }
    }
}
