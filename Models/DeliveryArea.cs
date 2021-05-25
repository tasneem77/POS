using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DeliveryArea
    {
        public int AreaSerial { get; set; }
        public string AreaName { get; set; }
        public decimal? AreaCharge { get; set; }
    }
}
