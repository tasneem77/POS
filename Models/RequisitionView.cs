using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RequisitionView
    {
        public string TransNo { get; set; }
        public DateTime? TransDate { get; set; }
        public int? Year { get; set; }
        public string ReqDocumentNo { get; set; }
        public DateTime? ReqDocumentDate { get; set; }
        public string ComCode { get; set; }
        public string CompanyNameL1 { get; set; }
        public string CompanyNameL2 { get; set; }
        public string FromStoCode { get; set; }
        public string FromStoreNameL1 { get; set; }
        public string FromStoreNameL2 { get; set; }
        public string ToStoCode { get; set; }
        public string ToStoreNameL1 { get; set; }
        public string ToStoreNameL2 { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string RequisitionStatus { get; set; }
        public string RequisitionStatusDescr { get; set; }
        public int LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItmCode1 { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItemNameL2 { get; set; }
        public string DescriptionInSales { get; set; }
        public string ItmUnitCode { get; set; }
        public string UnitNameL1 { get; set; }
        public string UnitNameL2 { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalItemCost { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
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
