using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseOrderHeaderView
    {
        public string Poserial { get; set; }
        public DateTime? Podate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? PostartDate { get; set; }
        public DateTime? PoendDate { get; set; }
        public DateTime? PoinsertDate { get; set; }
        public string PoinsertUid { get; set; }
        public DateTime? PoupdateDate { get; set; }
        public DateTime? PopostingDate { get; set; }
        public int? Postatus { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDateTime { get; set; }
        public string ClosedBy { get; set; }
        public string ClosedDateTime { get; set; }
        public string PoDesc { get; set; }
        public int? Poyear { get; set; }
        public string ComCode { get; set; }
        public string CompanyName1 { get; set; }
        public string CompanyName2 { get; set; }
        public string StoCode { get; set; }
        public string StoName1 { get; set; }
        public string StoName2 { get; set; }
        public string DeliveryAddress { get; set; }
        public int? PototalItems { get; set; }
        public string PocurrencyCode { get; set; }
        public string PocurrencyName { get; set; }
        public string PocurrencyNameL2 { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string BaseCurrencyName { get; set; }
        public string BaseCurrencyNameL2 { get; set; }
        public decimal? PototalValue { get; set; }
        public decimal? BaseTotalValue { get; set; }
        public decimal? PototalTax { get; set; }
        public decimal? BaseTotalTax { get; set; }
        public decimal? PototalShippingExpenses { get; set; }
        public decimal? BasePototalShippingExpenses { get; set; }
        public decimal? PootherExpenses { get; set; }
        public decimal? BaseOtherExpenses { get; set; }
        public int? PovenSerial { get; set; }
        public string VendorName { get; set; }
        public string VendorName2 { get; set; }
        public string Poremarks { get; set; }
    }
}
