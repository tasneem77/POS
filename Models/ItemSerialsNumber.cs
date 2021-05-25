using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSerialsNumber
    {
        public int? ItmSerialId { get; set; }
        public string SerialCode { get; set; }
        public string SerialNameL1 { get; set; }
        public string SerialNameL2 { get; set; }
    }
}
