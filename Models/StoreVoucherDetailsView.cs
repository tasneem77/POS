using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StoreVoucherDetailsView
    {
        public string VoucherNo { get; set; }
        public int LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ItemName2 { get; set; }
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public int? ModelId { get; set; }
        public string ModelDescription { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public string UnitCode { get; set; }
        public string UnitNameL1 { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? PreviousBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
