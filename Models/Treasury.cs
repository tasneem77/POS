using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Treasury
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string GlaccountCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public bool? Status { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
