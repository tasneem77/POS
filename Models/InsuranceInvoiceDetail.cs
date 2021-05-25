using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class InsuranceInvoiceDetail
    {
        public string InvoiceRefNo { get; set; }
        public int? PatientId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public decimal? InsuranceCompanyAmount { get; set; }
        public int? InsurancePlanId { get; set; }
        public int? CustomerId { get; set; }
    }
}
