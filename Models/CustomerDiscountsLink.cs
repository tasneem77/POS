using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CustomerDiscountsLink
    {
        public int? CustomerId { get; set; }
        public int? DiscountId { get; set; }
        public bool? Status { get; set; }
    }
}
