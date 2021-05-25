using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseRequestHeaderView
    {
        public string ComCode { get; set; }
        public string ComName1 { get; set; }
        public string ComName2 { get; set; }
        public string StoCode { get; set; }
        public string StoName1 { get; set; }
        public string StoName2 { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName1 { get; set; }
        public string DepartmentName2 { get; set; }
        public string Prserial { get; set; }
        public int Pryear { get; set; }
        public string PrdocNo { get; set; }
        public string Prremarks { get; set; }
        public int? PrtotalItems { get; set; }
        public string PrupdateUid { get; set; }
        public DateTime? PrupdateDate { get; set; }
        public string PrinsertUid { get; set; }
        public DateTime? PrinsertDate { get; set; }
        public int? PrpostFlag { get; set; }
        public string PostFlagDesc { get; set; }
        public DateTime? PrpostingDate { get; set; }
        public string PrpostUserCode { get; set; }
        public string Poserial { get; set; }
        public int? PrvenSerial { get; set; }
        public string VendorName1 { get; set; }
        public string VendorName2 { get; set; }
        public string PrcurrencyCode { get; set; }
        public string CurrencyName1 { get; set; }
        public string CurrencyName2 { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string BaseCurrencyName1 { get; set; }
        public string BaseCurrencyName2 { get; set; }
        public decimal? CurrencyXrate { get; set; }
        public decimal? PrtotalValue { get; set; }
        public decimal? BaseTotalValue { get; set; }
    }
}
