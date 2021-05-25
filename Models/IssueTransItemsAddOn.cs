using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssueTransItemsAddOn
    {
        public int Id { get; set; }
        public string TransNo { get; set; }
        public int TerminalId { get; set; }
        public string StoCode { get; set; }
        public string ComCode { get; set; }
        public int MainItmSerial { get; set; }
        public int? IssItmSerial { get; set; }
        public int LevelId { get; set; }
        public int LineSerial { get; set; }
        public decimal MainQty { get; set; }
        public string MainUnitCode { get; set; }
        public int AddOnsItmSerial { get; set; }
        public decimal AddOnsRecipeQty { get; set; }
        public int AddOnsRecipeUnitId { get; set; }
        public decimal AddOnsQty { get; set; }
        public decimal AddOnsSalesPrice { get; set; }
        public decimal AddOnsTotalPrice { get; set; }
        public int? Ordered { get; set; }
        public int? RefrencedId { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertUid { get; set; }
    }
}
