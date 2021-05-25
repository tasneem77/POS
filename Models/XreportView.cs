using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class XreportView
    {
        public string NameL1 { get; set; }
        public decimal? ItmQty { get; set; }
        public decimal? ItmValue { get; set; }
        public string GroupName { get; set; }
        public int? ShId { get; set; }
        public int? ItmSerial { get; set; }
        public int? Nature { get; set; }
        public int CashSerial { get; set; }
        public string SoldItemType { get; set; }
    }
}
