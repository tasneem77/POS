using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseOrderView
    {
        public string Poserial { get; set; }
        public DateTime? Podate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? PostartDate { get; set; }
        public DateTime? PoendDate { get; set; }
        public DateTime? PoinsertDate { get; set; }
        public string PoinsertUid { get; set; }
        public DateTime? PoupdateDate { get; set; }
        public string PoupdateUid { get; set; }
        public DateTime? PopostingDate { get; set; }
        public int? Postatus { get; set; }
        public string PoDesc { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDateTime { get; set; }
        public string ClosedBy { get; set; }
        public string ClosedDateTime { get; set; }
        public string PopaymentType { get; set; }
        public int? Poyear { get; set; }
        public string ComCode { get; set; }
        public string CompanyName { get; set; }
        public string StoCode { get; set; }
        public string StoName { get; set; }
        public string DeliveryAddress { get; set; }
        public int? PototalItems { get; set; }
        public string PocurrencyCode { get; set; }
        public string PocurrencyName { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string BaseCurrencyName { get; set; }
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
        public string Poremarks { get; set; }
        public int PodlineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public decimal? Podqty { get; set; }
        public decimal ReceivedQty { get; set; }
        public string PodpurchaseUnit { get; set; }
        public string UnitName { get; set; }
        public decimal? PodpurchasePrice { get; set; }
        public decimal? PodpurchaseBasePrice { get; set; }
        public decimal? PodtotalLine { get; set; }
        public decimal? PodtotalBaseLine { get; set; }
        public decimal? PodlastPurchasePrice { get; set; }
        public int? Podreceived { get; set; }
        public string LineStatus { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
    }
}
