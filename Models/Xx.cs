using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Xx
    {
        public int ItmSerial { get; set; }
        public int ModelId { get; set; }
        public string ModelCode { get; set; }
        public int AttributeId { get; set; }
        public string AttributeDesc { get; set; }
        public int ArrtibuteValueId { get; set; }
        public string AttributeValueDesc { get; set; }
    }
}
