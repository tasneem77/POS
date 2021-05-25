using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchasingItemByVendorView
    {
        public string NameL1 { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? TransUnitPrice { get; set; }
        public decimal? ItemDiscountValue { get; set; }
        public decimal? TotalQtyPrice { get; set; }
        public string ItmInputCode { get; set; }
        public decimal? PreviouseBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public string UpdateUid { get; set; }
        public int RecTransSerial { get; set; }
        public decimal? TransSalesTaxValue { get; set; }
        public string Expr2 { get; set; }
        public DateTime? TransDate { get; set; }
        public string StoCode { get; set; }
        public int? VendorSerial { get; set; }
        public decimal? CurrentBalance { get; set; }
        public string Expr1 { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
    }
}
