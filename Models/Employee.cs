using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Employee
    {
        public Employee()
        {
            SalesMen = new HashSet<SalesMan>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValueLimit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public decimal? CreditLimit { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? NationalId { get; set; }
        public int? StatusFlag { get; set; }
        public string BranchId { get; set; }
        public byte[] Picture { get; set; }
        public string FingerPrint { get; set; }
        public decimal? HourlyRate { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? LastClockIn { get; set; }
        public DateTime? LastClockOut { get; set; }

        public virtual ICollection<SalesMan> SalesMen { get; set; }
    }
}
