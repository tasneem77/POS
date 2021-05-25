using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class BillTransDetailsView
    {
        public string BillTransNo { get; set; }
        public int? AccId { get; set; }
        public string Code { get; set; }
        public string NameL1 { get; set; }
        public decimal? LineQty { get; set; }
        public decimal? LinePrice { get; set; }
        public decimal? LineDiscountValue { get; set; }
        public decimal? TotalLineValue { get; set; }
    }
}
