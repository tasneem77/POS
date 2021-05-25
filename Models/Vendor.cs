using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Vendor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ComCode { get; set; }
        public int? AccountId { get; set; }
        public string AccountCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string CurrCode { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string PaymentType { get; set; }
        public decimal? TotalPurchases { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? TotalCredit { get; set; }
        public decimal? Balance { get; set; }
        public string Status { get; set; }
        public DateTime LastUdate { get; set; }
        public string UserId { get; set; }
        public string MainSub { get; set; }
        public int? MainVendorId { get; set; }
        public int? PaymentDays { get; set; }
        public int? VendorLastItmSerial { get; set; }
    }
}
