using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CustomerStatementView
    {
        public int Id { get; set; }
        public int? CusId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerName2 { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public int? TransType { get; set; }
        public string TransTypeDesc { get; set; }
        public string RefNo { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public decimal? TransDateBalance { get; set; }
        public DateTime? InsertDate { get; set; }
        public int Ob { get; set; }
        public int Cb { get; set; }
        public int? PostFlag { get; set; }
        public decimal? CreditLimit { get; set; }
        public string CreditPeriod { get; set; }
        public int? SalesManId { get; set; }
        public string SalesManName { get; set; }
    }
}
