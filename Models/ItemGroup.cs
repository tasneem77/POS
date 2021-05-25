using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemGroup
    {
        public string Code { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string Tag { get; set; }
        public bool? Status { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
        public int? GroupColor { get; set; }
    }
}
