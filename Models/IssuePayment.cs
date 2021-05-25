using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssuePayment
    {
        public int Id { get; set; }
        public string TransNo { get; set; }
        public int TerminalId { get; set; }
        public string StoCode { get; set; }
        public string ComCode { get; set; }
        public int PayType { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal? PaidAmountinBase { get; set; }
        public int CurrencyId { get; set; }
        public int ShiftId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int? Year { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int TransTerminalId { get; set; }
    }
}
