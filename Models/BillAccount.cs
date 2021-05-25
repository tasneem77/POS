using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class BillAccount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public int? ParentId { get; set; }
        public int? PreferedVendorId { get; set; }
        public decimal? LastAmount { get; set; }
        public string AccountType { get; set; }
        public string Status { get; set; }
        public string InserUid { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
