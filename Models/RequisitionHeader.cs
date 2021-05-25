using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RequisitionHeader
    {
        public string TransNo { get; set; }
        public string ComCode { get; set; }
        public string FromStoCode { get; set; }
        public string ToStoCode { get; set; }
        public int? Year { get; set; }
        public DateTime? TransDate { get; set; }
        public string ReqDocumentNo { get; set; }
        public DateTime? ReqDocumentDate { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string RequestStatus { get; set; }
        public string PostFlag { get; set; }
        public DateTime? PostingDate { get; set; }
        public string Remarks { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
    }
}
