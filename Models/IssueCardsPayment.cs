using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class IssueCardsPayment
    {
        public string TransNo { get; set; }
        public int TerminalId { get; set; }
        public int ShiftId { get; set; }
        public int CardId { get; set; }
        public decimal Amount { get; set; }
        public decimal CardPercent { get; set; }
        public decimal? BankValue { get; set; }
        public decimal AmountAfterPercent { get; set; }
        public string CardNo { get; set; }
        public DateTime? CardExpiry { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public int IssuePaymentId { get; set; }
    }
}
