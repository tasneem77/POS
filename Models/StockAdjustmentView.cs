using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StockAdjustmentView
    {
        public string TransTypeCodeLevel1 { get; set; }
        public string TransNo { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string PostFlag { get; set; }
        public DateTime? PostingDate { get; set; }
        public string PostedBy { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string StoreName { get; set; }
        public string StoCode { get; set; }
        public decimal? NetAmount { get; set; }
    }
}
