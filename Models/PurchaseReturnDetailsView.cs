using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseReturnDetailsView
    {
        public string Pirserial { get; set; }
        public int RecTransSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string ItmCode1 { get; set; }
        public string DescriptionInSales { get; set; }
        public string PurchaseUnitCode { get; set; }
        public string PurchaseUnitName1 { get; set; }
        public string PurchaseUnitName2 { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? TransUnitPrice { get; set; }
        public decimal? ItemDiscountValue { get; set; }
        public decimal? DocumentDiscountValue { get; set; }
        public decimal? TotalCustomValue { get; set; }
        public decimal? OtherCostValue { get; set; }
        public decimal? ExpensesDistributed { get; set; }
        public decimal? TransItmTaxValue { get; set; }
        public decimal? TransSalesTaxValue { get; set; }
        public decimal? TotalQtyPrice { get; set; }
        public string Year { get; set; }
        public decimal? TransLastPurchasePrice { get; set; }
        public decimal? ItmSalesPrice { get; set; }
        public decimal? PreviouseBalance { get; set; }
        public decimal? NextBalance { get; set; }
    }
}
