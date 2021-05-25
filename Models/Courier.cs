using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Courier
    {
        public int CourierId { get; set; }
        public string CourierCode { get; set; }
        public string CourierName { get; set; }
        public bool? Status { get; set; }
        public bool? CashOnDelivery { get; set; }
        public bool? OnlinePayment { get; set; }
        public int? CreditCustomerId { get; set; }
    }
}
