using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemMasterFromErp
    {
        public int ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string GroupCode { get; set; }
        public int? CategoryId { get; set; }
        public string LargUnitCode { get; set; }
        public string MedUnitCode { get; set; }
        public string SalesUnitCode { get; set; }
        public double? FactorMedToSmall { get; set; }
        public double? FactorLargToMed { get; set; }
        public double? FactorPurchaseToSmall { get; set; }
        public int? IsWeightFlag { get; set; }
        public int? Status { get; set; }
        public int? AllowSales { get; set; }
        public string TypeCode { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? LastSalesPrice { get; set; }
        public decimal? CurrentBalance { get; set; }
        public int? Nature { get; set; }
        public int? ShowButtonInSales { get; set; }
        public int? UseExpiry { get; set; }
    }
}
