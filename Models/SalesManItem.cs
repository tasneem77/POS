using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesManItem
    {
        public int Id { get; set; }
        public int? SalesManId { get; set; }
        public int? ItmSerial { get; set; }
    }
}
