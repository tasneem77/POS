using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Serial
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string ModuleId { get; set; }
        public string TransType1 { get; set; }
        public string TransType2 { get; set; }
        public int? Serial1 { get; set; }
        public string InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Year { get; set; }
        public int? HoldSerial { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string TerminalCode { get; set; }
    }
}
