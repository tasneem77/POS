using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSerialNoTempAttributesValue
    {
        public int ItmSntid { get; set; }
        public string Reference { get; set; }
        public int? LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string SerialNo { get; set; }
        public int SerialNoAttributeId { get; set; }
        public string SerialNoAttributeDesc { get; set; }
        public int? SerialNoAttributeValueId { get; set; }
        public string SerialNoAttributeValueDesc { get; set; }
        public int? Status { get; set; }
    }
}
