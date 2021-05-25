using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSeason
    {
        public int? SeasonId { get; set; }
        public string SeasonCode { get; set; }
        public string SeasonNameL1 { get; set; }
        public string SeasonNameL2 { get; set; }
    }
}
