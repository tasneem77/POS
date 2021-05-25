using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemModel
    {
        public int ModelId { get; set; }
        public string ModelCode { get; set; }
        public string ModelDescription { get; set; }
        public string GroupCode { get; set; }
        public int? CategoryId { get; set; }
        public int? LargUnitCode { get; set; }
        public int? MedUnitCode { get; set; }
        public int? SalesUnitCode { get; set; }
        public int? PurchaseUnitCode { get; set; }
        public int? PreferedVendor { get; set; }
        public decimal? FactorMedToSmall { get; set; }
        public decimal? FactorLargToMed { get; set; }
        public decimal? FactorPurchaseToSmall { get; set; }
        public decimal? MinQty { get; set; }
        public decimal? MaxQty { get; set; }
        public decimal? ReorderQty { get; set; }
        public decimal? SalesPrice { get; set; }
        public int? XAttributeId { get; set; }
        public int? YAttributeId { get; set; }
    }
}
