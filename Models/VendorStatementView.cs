using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class VendorStatementView
    {
        public int? VenId { get; set; }
        public string VendorName { get; set; }
        public string VendorName2 { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public int? TransType { get; set; }
        public string TransTypeDesc { get; set; }
        public string RefNo { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public decimal? TransDateBalance { get; set; }
        public DateTime? InsertDate { get; set; }
        public int Ob { get; set; }
        public int Cb { get; set; }
        public int? PostFlag { get; set; }
    }
}
