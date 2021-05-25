using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemSalesPriceView
    {
        public string ItmCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string DescriptionInSales { get; set; }
        public int? CategoryId { get; set; }
        public int ItmSerial { get; set; }
        public string StoCode { get; set; }
        public string Picture { get; set; }
        public int? ShowButtonInSales { get; set; }
        public decimal Price { get; set; }
        public decimal? CurrentBalance { get; set; }
        public string GroupCode { get; set; }
        public string SalesUnitCode { get; set; }
        public int? Status { get; set; }
        public string ModelCode { get; set; }
        public string Xattribute { get; set; }
        public string Yattribute { get; set; }
        public string GroupName { get; set; }
        public string CategoryName { get; set; }
        public string UnitName { get; set; }
        public string TypeCode { get; set; }
        public int? Nature { get; set; }
        public int? AllowSales { get; set; }
    }
}
