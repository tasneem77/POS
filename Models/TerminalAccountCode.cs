using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TerminalAccountCode
    {
        public int TerminalCode { get; set; }
        public string SalesAccCode { get; set; }
        public int? SalesAccId { get; set; }
        public string TreasureAccCode { get; set; }
        public int? TreasureAccId { get; set; }
        public string CreditCardAccCode { get; set; }
        public int? CreditCardAccId { get; set; }
        public string DiscountAccCode { get; set; }
        public int? DiscountAccId { get; set; }
        public string DeliveryFeesAccCode { get; set; }
        public int? DeliveryFeesAccId { get; set; }
        public string SalesTaxAccCode { get; set; }
        public int? SalesTaxAccId { get; set; }
        public string DebitAccCode { get; set; }
        public int? DebitAccId { get; set; }
        public string CashDiffAccCode { get; set; }
        public int? CashDiffAccId { get; set; }
        public string CogsAccCode { get; set; }
        public int? CogsAccId { get; set; }
        public string StoreAccCode { get; set; }
        public int? StoreAccId { get; set; }
    }
}
