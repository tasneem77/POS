using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class InsuranceInvoiceAttributeDetail
    {
        public string InvoiceRefNo { get; set; }
        public int InsuranceAttributeId { get; set; }
        public string InsuranceAttributeDescription { get; set; }
        public int? InsuranceAttributeValueId { get; set; }
        public string InsuranceAttributeValue { get; set; }
    }
}
