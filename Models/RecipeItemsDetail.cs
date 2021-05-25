using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RecipeItemsDetail
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string MainItemName { get; set; }
        public string MainItemUnitType { get; set; }
        public string MainItemUnitTypeDesc { get; set; }
        public string MainItemUnitCode { get; set; }
        public string MainItemUnitName { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }
        public int MaterialItmSerial { get; set; }
        public string MaterialItemCode { get; set; }
        public string MaterialItemname { get; set; }
        public string StoCode { get; set; }
        public string StoreName { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal? ItmQty { get; set; }
        public string SalesUnitCode { get; set; }
        public string UnitName { get; set; }
        public decimal? MaterialCost { get; set; }
        public decimal? TotalMaterialCost { get; set; }
        public decimal? MaterialSalesPrice { get; set; }
        public decimal? MaterialTotalPrice { get; set; }
    }
}
