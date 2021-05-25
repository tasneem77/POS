using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ModelAttributeValue
    {
        public int AttributeValueId { get; set; }
        public int? AttributeId { get; set; }
        public string AttributeValue { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
    }
}
