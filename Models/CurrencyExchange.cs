using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CurrencyExchange
    {
        public string ExBaseCode { get; set; }
        public string ExCurrencyCode { get; set; }
        public DateTime ExchangeDate { get; set; }
        public decimal? ExBuyCash { get; set; }
        public decimal? ExSellCash { get; set; }
        public decimal? ExBuyTransfer { get; set; }
        public decimal? ExSellTransfer { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
