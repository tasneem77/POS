using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemBalanceInStoresView
    {
        public int ItmSerial { get; set; }
        public string StoreName { get; set; }
        public string SmallBalance { get; set; }
        public string MeduimBalance { get; set; }
        public string LargeBalance { get; set; }
        public string PurchaseBalance { get; set; }
        public string MainSub { get; set; }
    }
}
