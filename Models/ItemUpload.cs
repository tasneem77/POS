using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemUpload
    {
        public int LineSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItemNameL2 { get; set; }
        public string DescriptionInSales { get; set; }
        public string DescriptionInPurchase { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryId { get; set; }
        public string LargeUnitName { get; set; }
        public string LargUnitCode { get; set; }
        public string MedUnitName { get; set; }
        public string MedUnitCode { get; set; }
        public string SalesUnitName { get; set; }
        public string SalesUnitCode { get; set; }
        public string PurchaseUnitName { get; set; }
        public string PurchaseUnitCode { get; set; }
        public string VendorName { get; set; }
        public int? PreferedVendor { get; set; }
        public string ModelDescription { get; set; }
        public int? ModelId { get; set; }
        public double? FactorMedToSmall { get; set; }
        public double? FactorLargToMed { get; set; }
        public double? FactorPurchaseToSmall { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public decimal? DefaultSalesPrice { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public decimal? PurchaseTaxPercent { get; set; }
        public decimal? PurchaseTaxAmount { get; set; }
        public decimal? SalesTaxAmount { get; set; }
        public decimal? OfferDefaultPrice { get; set; }
        public decimal? PriceListDefaultPrice { get; set; }
        public bool? Valid { get; set; }
        public string Remarks { get; set; }
    }
}
