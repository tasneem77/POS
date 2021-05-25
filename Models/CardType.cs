using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CardType
    {
        public int Id { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public decimal BankPercent { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
    }
}
