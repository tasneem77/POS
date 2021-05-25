using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class InsuranceCompany
    {
        public int IncId { get; set; }
        public string IncCode { get; set; }
        public int? IncCreditCustomerId { get; set; }
        public string IncNameL1 { get; set; }
        public string IncNameL2 { get; set; }
        public string IncPhone1 { get; set; }
        public string IncPhone2 { get; set; }
        public string IncAddress1 { get; set; }
        public string IncAddress2 { get; set; }
        public string IncCountry { get; set; }
        public string IncInsertedBy { get; set; }
        public string IncUpdatedBy { get; set; }
        public DateTime? IncInsertedDate { get; set; }
        public DateTime? IncUpdatedDate { get; set; }
        public string IncReportDesign { get; set; }
    }
}
