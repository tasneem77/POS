using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSerialNoTransactionInOutView
    {
        public string SerialNo { get; set; }
        public long? RowNumber { get; set; }
        public string Reference { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InOut { get; set; }
        public string StoCode { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
