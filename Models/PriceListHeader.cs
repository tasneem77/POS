using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PriceListHeader
    {
        public string PriceListCode { get; set; }
        public string PriceListName { get; set; }
        public bool Status { get; set; }
        public bool PostFlag { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
