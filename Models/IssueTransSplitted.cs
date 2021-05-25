using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssueTransSplitted
    {
        public string OrigSalesTrnsId { get; set; }
        public string SpltSalestrnsId { get; set; }
        public int? GuestNo { get; set; }
        public bool? Tendered { get; set; }
    }
}
