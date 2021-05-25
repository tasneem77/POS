using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemUnit
    {
        public int Iucode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string Remarks { get; set; }
        public bool? Status { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
    }
}
