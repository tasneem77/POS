using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemAttributesValuesView
    {
        public int ItmSerial { get; set; }
        public int? ModelId { get; set; }
        public string ItmCode { get; set; }
        public string ModelCode { get; set; }
        public string ModelDescription { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
    }
}
