using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class WorkOrderHeaderView
    {
        public string TransNo { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string ComCode { get; set; }
        public string CompanyName1 { get; set; }
        public string CompanyName2 { get; set; }
        public string StoCode { get; set; }
        public string StoreName1 { get; set; }
        public string StoreName2 { get; set; }
        public string WorkOrderType { get; set; }
        public string WorkOrderTypeDesc { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string PostFlag { get; set; }
        public string PostingDesc { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? RecievedFlag { get; set; }
        public string RecievedFlagDesc { get; set; }
        public decimal TotalQty { get; set; }
        public decimal TotalCost { get; set; }
    }
}
