using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSerialNoAttributeRelation
    {
        public int ItmSerial { get; set; }
        public int SerialNoAttributeId { get; set; }
        public string SerialNoAttributeDesc { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
    }
}
