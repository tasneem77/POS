using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PriceListAssigning
    {
        public int Id { get; set; }
        public string AssignType { get; set; }
        public string AssignTypeCode { get; set; }
        public string PriceListCode { get; set; }
        public DateTime ApplyPriceDate { get; set; }
        public bool? Status { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
