using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SerialNoUnitCost
    {
        public int Id { get; set; }
        public int? ItmSerial { get; set; }
        public string SerialNo { get; set; }
        public decimal? PrevCost { get; set; }
        public decimal? UnitCost { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Reference { get; set; }
    }
}
