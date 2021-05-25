using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RecieveTransItem
    {
        public int RecTransSerial { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public string TransNo { get; set; }
        public int? ReturnTransNo { get; set; }
        public string TransMeasureUnit { get; set; }
        public int? VendorSerial { get; set; }
        public int? ItmSerial { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? TransUnitPrice { get; set; }
        public decimal? ItemDiscountValue { get; set; }
        public decimal? DocumentDiscountValue { get; set; }
        public decimal? TotalCustomValue { get; set; }
        public decimal? OtherCostValue { get; set; }
        public decimal? ExpensesDistributed { get; set; }
        public decimal? TransItmTaxValue { get; set; }
        public decimal? TransSalesTaxValue { get; set; }
        public decimal? TotalQtyPrice { get; set; }
        public decimal? TotalQtyCost { get; set; }
        public decimal? TotalSalesPrice { get; set; }
        public string Year { get; set; }
        public decimal? TransLastPurchasePrice { get; set; }
        public decimal? ItmSalesPrice { get; set; }
        public string ItmInputCode { get; set; }
        public string OtherStore { get; set; }
        public decimal? PreviouseBalance { get; set; }
        public decimal? NextBalance { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal? BonusQty { get; set; }
        public int? LineSerial { get; set; }
        public string Remarks { get; set; }
    }
}
