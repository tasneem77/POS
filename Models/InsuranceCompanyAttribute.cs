using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class InsuranceCompanyAttribute
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public int? DataType { get; set; }
        public bool? IsMandatory { get; set; }
        public int? DataLength { get; set; }
        public bool? Active { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
