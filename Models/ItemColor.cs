using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemColor
    {
        public int? ColorId { get; set; }
        public string ColorCode { get; set; }
        public string ColorNameL1 { get; set; }
        public string ColorNameL2 { get; set; }
    }
}
