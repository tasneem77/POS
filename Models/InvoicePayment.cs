using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class InvoicePayment
    {
        public int Id { get; set; }
        public string PvtransNo { get; set; }
        public int? TransType { get; set; }
        public string InvoiceTransNo { get; set; }
        public string TransTypeCodeLevel1 { get; set; }
        public string TransTypeCodeLevel2 { get; set; }
        public int? BeneficiaryId { get; set; }
        public int? BeneficiaryType { get; set; }
        public decimal? InvAmount { get; set; }
        public decimal? Amount { get; set; }
        public int? PostFlag { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
