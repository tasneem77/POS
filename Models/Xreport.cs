using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Xreport
    {
        public int ShId { get; set; }
        public int ItmSerial { get; set; }
        public decimal? ItmQty { get; set; }
        public decimal? ItmValue { get; set; }
        public decimal? ItmTaxValue { get; set; }
        public string ItmSalesDesc { get; set; }
        public string ItmGroupCode { get; set; }
        public int TerminalId { get; set; }
        public string StoCode { get; set; }
        public decimal? AverageCost { get; set; }
        public int? CategoryId { get; set; }
    }
}
