using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TransactionsEvent
    {
        public int Id { get; set; }
        public int? EventId { get; set; }
        public string TransNo { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
