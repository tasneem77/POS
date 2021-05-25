using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class LoyaltySetupDetail
    {
        public int Id { get; set; }
        public int? HeaderId { get; set; }
        public int? LineSerial { get; set; }
        public decimal? FromPoint { get; set; }
        public decimal? ToPoint { get; set; }
        public decimal? Value { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
