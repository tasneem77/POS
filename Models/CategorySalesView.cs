using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CategorySalesView
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserCode { get; set; }
        public string StoCode { get; set; }
        public string StoName { get; set; }
        public string ComCode { get; set; }
        public string CompanyName { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int? ShiftFlag { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Total { get; set; }
        public decimal? NetTotal { get; set; }
        public int CashSerial { get; set; }
    }
}
