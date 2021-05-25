using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SerialNoAttribute
    {
        public int AttributeId { get; set; }
        public string AttributeNameL1 { get; set; }
        public string AttributeNameL2 { get; set; }
        public int? DataType { get; set; }
        public int? DataEntry { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
    }
}
