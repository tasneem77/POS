using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemVendorsView
    {
        public int? VendorSerial { get; set; }
        public string VendorNameL1 { get; set; }
        public int? ItmSerial { get; set; }
        public string Piserial { get; set; }
        public string ItmCode { get; set; }
        public string ItemName { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? TransDate { get; set; }
        public string PurchaseUnitName1 { get; set; }
        public string CurrencyNameL1 { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? BonusQty { get; set; }
        public decimal? TransUnitPrice { get; set; }
        public decimal? ItemDiscountValue { get; set; }
    }
}
