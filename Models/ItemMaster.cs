using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemMaster
    {
        public ItemMaster()
        {
            ItemCompanyPrices = new HashSet<ItemCompanyPrice>();
            ItemSalesPrices = new HashSet<ItemSalesPrice>();
            PromotionDetails = new HashSet<PromotionDetail>();
        }

        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string DescriptionInSales { get; set; }
        public string DescriptionInPurchase { get; set; }
        public string GroupCode { get; set; }
        public int? CategoryId { get; set; }
        public string LargUnitCode { get; set; }
        public string MedUnitCode { get; set; }
        public string SalesUnitCode { get; set; }
        public string PurchaseUnitCode { get; set; }
        public int? PreferedVendor { get; set; }
        public double? FactorMedToSmall { get; set; }
        public double? FactorLargToMed { get; set; }
        public double? FactorPurchaseToSmall { get; set; }
        public string Picture { get; set; }
        public int? QuickFlag { get; set; }
        public DateTime? LastSalesDate { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public double? MinQty { get; set; }
        public double? MaxQty { get; set; }
        public double? ReorderQty { get; set; }
        public int? SerialId { get; set; }
        public string ExpireDate { get; set; }
        public int? IsWeightFlag { get; set; }
        public int? Status { get; set; }
        public int? AllowSales { get; set; }
        public int? AllowPurchase { get; set; }
        public int? AllowReturn { get; set; }
        public int? UseAddOns { get; set; }
        public string TypeCode { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public decimal? LastSalesPrice { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? Discount { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public decimal? PurchaseTaxPercent { get; set; }
        public decimal? PurchaseTaxAmount { get; set; }
        public decimal? SalesTaxAmount { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
        public string ItmCode1 { get; set; }
        public string ItmCode2 { get; set; }
        public string ItmCode3 { get; set; }
        public string ItmCode4 { get; set; }
        public string ItmCode5 { get; set; }
        public string ItmCode6 { get; set; }
        public string ItmCode7 { get; set; }
        public string ItmCode8 { get; set; }
        public string ItmCode9 { get; set; }
        public string ItmCode10 { get; set; }
        public string ItmCode11 { get; set; }
        public string ItmCode12 { get; set; }
        public string ItmCode13 { get; set; }
        public string ItmCode14 { get; set; }
        public string ItmCode15 { get; set; }
        public string ItmCode16 { get; set; }
        public string ItmCode17 { get; set; }
        public string ItmCode18 { get; set; }
        public string ItmCode19 { get; set; }
        public string ItmCode20 { get; set; }
        public string ItmIsCat { get; set; }
        public int? ItmCatMixNo { get; set; }
        public int? Nature { get; set; }
        public int? ShowButtonInSales { get; set; }
        public string ItmPricingType { get; set; }
        public decimal? ItmMarkup { get; set; }
        public decimal? ItmProfit { get; set; }
        public int? UseExpiry { get; set; }
        public int? AllowEditPrice { get; set; }
        public int? ModelId { get; set; }
        public decimal? LandedCost { get; set; }
        public string DefaultSalesUnit { get; set; }
        public string MajorTime { get; set; }
        public int? UseLinkedItems { get; set; }
        public decimal? InOrderQty { get; set; }
        public decimal? AvailableQty { get; set; }
        public int? AllowChangeName { get; set; }
        public int? UseSerialNo { get; set; }
        public int? QuickSetupItem { get; set; }
        public decimal? OfferDefaultPrice { get; set; }
        public decimal? PriceListDefaultPrice { get; set; }
        public int? KitchenId { get; set; }

        public virtual ICollection<ItemCompanyPrice> ItemCompanyPrices { get; set; }
        public virtual ICollection<ItemSalesPrice> ItemSalesPrices { get; set; }
        public virtual ICollection<PromotionDetail> PromotionDetails { get; set; }
    }
}
