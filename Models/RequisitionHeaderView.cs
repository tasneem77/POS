using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RequisitionHeaderView
    {
        public string Reqserial { get; set; }
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
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal TotalQty { get; set; }
    }
}
