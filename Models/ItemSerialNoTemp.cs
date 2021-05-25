using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSerialNoTemp
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string TransTypeCodeLeve1 { get; set; }
        public string TransTypeCodeLeve2 { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TermCode { get; set; }
        public int? LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string SerialNo { get; set; }
        public int? Status { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
