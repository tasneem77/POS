﻿using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemExpiryTempTransactionView
    {
        public string TransNo { get; set; }
        public int? LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItemNameL1 { get; set; }
        public string SalesUnitNameL1 { get; set; }
        public decimal? TransQty { get; set; }
        public decimal BonusQty { get; set; }
        public double? ExpQty { get; set; }
        public double? SmallQty { get; set; }
        public double? SmallBonusQty { get; set; }
        public decimal? SmallExpQty { get; set; }
    }
}