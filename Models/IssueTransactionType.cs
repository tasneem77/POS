using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssueTransactionType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public bool? Status { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
    }
}
