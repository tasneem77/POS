using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Branch
    {
        public int Id { get; set; }
        public string BrnCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
        public string CompanyCode { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
    }
}
