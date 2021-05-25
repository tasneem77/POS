using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RequisitionDetailsView
    {
        public string Reqserial { get; set; }
        public int LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ItmUnitCode { get; set; }
        public string UnitNameL1 { get; set; }
        public string UnitNameL2 { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalItemCost { get; set; }
        public decimal? ReqQty { get; set; }
        public decimal? ApprovedQty { get; set; }
        public decimal? NotApprovedQty { get; set; }
        public string ItemStatus { get; set; }
        public string ItemStatusDescr { get; set; }
        public decimal TransQty { get; set; }
        public decimal DelivQty { get; set; }
        public decimal NotDelivQty { get; set; }
        public string ItemTransferStatus { get; set; }
    }
}
