using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemsWithUnitsView
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemNameL1 { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public string ModelCode { get; set; }
        public string ModelDescription { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string UnitType { get; set; }
        public string UnitTypeDesc { get; set; }
    }
}
