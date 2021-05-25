using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Currency
    {
        public string CurrencyCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string Sympol { get; set; }
        public string Remarks { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
