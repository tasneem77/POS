using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DeliveryDetailsView
    {
        public int TransSerial { get; set; }
        public decimal? TrnsQty { get; set; }
        public decimal? BeforeDiscountPrice { get; set; }
        public string TerminalId { get; set; }
        public string StoCode { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string Phone { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string AreaName { get; set; }
        public decimal? AreaCharge { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
