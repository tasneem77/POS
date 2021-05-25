using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RequisitionItem
    {
        public string TransNo { get; set; }
        public int LineSerial { get; set; }
        public int? Year { get; set; }
        public DateTime? TransDate { get; set; }
        public int? ItmSerial { get; set; }
        public decimal? ReqQty { get; set; }
        public decimal? ApprovedQty { get; set; }
        public decimal? ReturnQty { get; set; }
        public string ItmUnitCode { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalItemCost { get; set; }
        public string RequestStatus { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
    }
}
