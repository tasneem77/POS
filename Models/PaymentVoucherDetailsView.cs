using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PaymentVoucherDetailsView
    {
        public string PvhtransNo { get; set; }
        public int LineSerial { get; set; }
        public int? VoucherType { get; set; }
        public string VoucherTypeDesc { get; set; }
        public decimal? Amount { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeDueDate { get; set; }
        public int? ChequeBankId { get; set; }
        public string BankName { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Remarks { get; set; }
        public string AccountCode { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
        public string CostCenterCode { get; set; }
        public int? CostCenterId { get; set; }
        public string CostCenterName { get; set; }
    }
}
