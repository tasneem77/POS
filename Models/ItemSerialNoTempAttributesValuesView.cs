﻿using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSerialNoTempAttributesValuesView
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemNameL1 { get; set; }
        public int Id { get; set; }
        public string Reference { get; set; }
        public int? LineSerial { get; set; }
        public string TransTypeCodeLeve1 { get; set; }
        public string TransTypeCodeLeve2 { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TermCode { get; set; }
        public string SerialNo { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
