using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSize
    {
        public int? SizeId { get; set; }
        public string SizeCode { get; set; }
        public string SizeNameL1 { get; set; }
        public string SizeNameL2 { get; set; }
    }
}
