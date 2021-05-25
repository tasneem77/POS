using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RetailCustomer
    {
        public string Phone { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string CardCode { get; set; }
        public string Address { get; set; }
        public int? AreaSerial { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public decimal? SalesVolume { get; set; }
        public decimal? LastSalesAmount { get; set; }
        public DateTime? LastSalesDate { get; set; }
        public decimal? OpeningBalancePoints { get; set; }
        public decimal? DebitPoints { get; set; }
        public decimal? CreditPoints { get; set; }
        public decimal? CurrentPointsBalance { get; set; }
        public bool? ApplyDiscount { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Gender { get; set; }
        public int Id { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }
        public string Phone5 { get; set; }
        public string Remarks { get; set; }
        public int? NationalityId { get; set; }
    }
}
