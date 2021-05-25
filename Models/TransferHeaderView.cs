using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TransferHeaderView
    {
        public string Traserial { get; set; }
        public DateTime? TransDate { get; set; }
        public int? Year { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string ComCode { get; set; }
        public string CompanyNameL1 { get; set; }
        public string CompanyNameL2 { get; set; }
        public string FromStoCode { get; set; }
        public string FromStoreNameL1 { get; set; }
        public string FromStoreNameL2 { get; set; }
        public string ToStoCode { get; set; }
        public string ToStoreNameL1 { get; set; }
        public string ToStoreNameL2 { get; set; }
        public decimal? TotalOthersValue { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string TransferStatus { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string RequisitionNo { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public string PostFlag { get; set; }
        public string PostingDesc { get; set; }
        public DateTime? PostingDate { get; set; }
        public decimal TotalQty { get; set; }
        public string PostedBy { get; set; }
    }
}
