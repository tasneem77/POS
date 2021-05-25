using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseOrderHeader
    {
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string Poserial { get; set; }
        public int Poyear { get; set; }
        public int? PovenSerial { get; set; }
        public string PocurrencyCode { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? CurrencyXrate { get; set; }
        public decimal? PototalValue { get; set; }
        public decimal? BaseTotalValue { get; set; }
        public decimal? PototalShippingExpenses { get; set; }
        public decimal? BasePototalShippingExpenses { get; set; }
        public decimal? PototalTax { get; set; }
        public decimal? BaseTotalTax { get; set; }
        public decimal? PootherExpenses { get; set; }
        public decimal? BaseOtherExpenses { get; set; }
        public string Poremarks { get; set; }
        public string PopaymentType { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? Podate { get; set; }
        public int? PototalItems { get; set; }
        public DateTime? PostartDate { get; set; }
        public DateTime? PoendDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public string PorequestSerial { get; set; }
        public int? Postatus { get; set; }
        public DateTime? PopostingDate { get; set; }
        public string PoupdateUid { get; set; }
        public DateTime? PoupdateDate { get; set; }
        public string PoinsertUid { get; set; }
        public DateTime? PoinsertDate { get; set; }
    }
}
