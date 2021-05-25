using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemStoreCompany
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public int ItmSerial { get; set; }
        public string TypeCode { get; set; }
        public decimal? MaxLimit { get; set; }
        public decimal? MinLimit { get; set; }
        public decimal? SafetyStock { get; set; }
        public decimal? ReorderPoint { get; set; }
        public decimal? AvrConsumptionDay { get; set; }
        public decimal? AvrConsumptionMonth { get; set; }
        public decimal? AvrConsumptionYear { get; set; }
        public decimal? Discount1 { get; set; }
        public decimal? Discount2 { get; set; }
        public decimal? Discount3 { get; set; }
        public decimal? OpenBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? AverageCost { get; set; }
        public string ItemLocation { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public DateTime? LastAddDate { get; set; }
        public string ItmUser { get; set; }
        public decimal? TaxValue { get; set; }
        public decimal? CashDiscount { get; set; }
        public decimal? MaxDiscount { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public decimal? InOrderQty { get; set; }
        public decimal? AvailableQty { get; set; }
    }
}
