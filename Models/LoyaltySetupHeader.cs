using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class LoyaltySetupHeader
    {
        public int Id { get; set; }
        public int? SetupType { get; set; }
        public DateTime? ApplyDate { get; set; }
        public bool? Status { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
