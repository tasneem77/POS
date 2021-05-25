using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class VendorStatement
    {
        public int Id { get; set; }
        public int? VenId { get; set; }
        public DateTime? TransDate { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public int? TransType { get; set; }
        public string RefNo { get; set; }
        public string DocumentNo { get; set; }
        public int? PostFlag { get; set; }
        public DateTime? PostDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
